angular.module('accountingApp')
  .factory('AuthService', function ($http) {
    var self = this;
    self.credentials = {};

    var login = function () {
      return $http.post('/api/auth/login', self.credentials);
    };

    return {
      login: login
    };
  });

