angular.module("app.services", ["ngResource"]).
       factory("PersonService", function ($resource) {
           return $resource(
               "/api/Person/:Id",
               { Id: "@Id" },
               {
                   "update": { method: "PUT" },
                   "save": {
                       method: "POST", datatype: 'json',
                       contentType: "application/x-www-form-urlencoded"
                   }
               }
          );
       });