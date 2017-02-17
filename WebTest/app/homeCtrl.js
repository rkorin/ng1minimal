; (function (angular) {
    'use strict';

    angular.module('home', [])
        .controller('homeCtrl', ['$scope', 'PersonService',
            function ($scope, PersonService) {

                function init() {                    
                    $scope.IsAnyPersonSelected = false;
                    load_list();
                }

                function load_list() {
                    $scope.LoadingListOfPersons = true;
                    $scope.EditMode = false;
                    $scope.ViewMode = false;
                    $scope.SelectedPerson = null;
                    $scope.Persons = PersonService.query(
                        function () {
                            $scope.LoadingListOfPersons = false;
                        });
                }

                function search(id) {
                    if ($scope.Persons && $scope.Persons.length) {
                        for (var i = 0; i < $scope.Persons.length; ++i)
                            if ($scope.Persons[i].Id == id)
                                return $scope.Persons[i];
                    }
                    return {};
                }

                $scope.selectPerson = function (id) {
                    $scope.EditMode = false;
                    $scope.ViewMode = true;
                    $scope.SelectedPerson = search(id);
                };

                $scope.deletePerson = function (id) {
                    var person = search(id);
                    person.deleted = true;
                    person.$delete();
                    $scope.EditMode = false;
                    $scope.ViewMode = false;
                };

                $scope.editPerson = function (id) {
                    $scope.EditMode = true;
                    $scope.ViewMode = false;
                    $scope.SelectedPerson = search(id);
                }

                $scope.createPerson = function () {
                    $scope.EditMode = true;
                    $scope.ViewMode = false;
                    $scope.SelectedPerson = {};
                }

                $scope.submit = function () {
                     
                    var o = $('#form1').serialize();

                    if ($scope.SelectedPerson.$save) {
                        $scope.SelectedPerson.$save(function () {
                            debugger;
                            load_list();
                        });
                    }
                    else PersonService.save(o, $scope.SelectedPerson,
                        function (e, d) {                            
                            //success
                            load_list();
                        });
                }

                $scope.validate = function (person) {
                    person = person || {};
                    return !person.FirstName || !person.LastName;
                }

                init();
            }]);
})(angular);