angular.module('accountingApp')
  .controller('LoginController', function (AuthService, $location, redirectUrl) {
    this.login = function () {
      AuthService.login().then(function () {
        if (redirectUrl) {
          return $location.url(redirectUrl);
        }
        return $location.path('/');
      });
    };
  });
