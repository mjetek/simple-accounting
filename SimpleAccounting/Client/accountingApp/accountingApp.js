angular.module('accountingApp', [
  'ngRoute',
  'ngResource',
  'ngMessages',
  'ngAnimate',
  'ui.utils', //todo: choose modules
  'ui.bootstrap',
  'ui.tree',
  'angular-loading-bar',
  'toastr'
]).config(function ($routeProvider) {
  $routeProvider
    .when('/login', {
      templateUrl: '/auth/login',
      controller: 'LoginController',
      controllerAs: 'vm'
    })
    .when('/company/register', {
      templateUrl: '/company/register',
      controller: 'RegisterCompanyController',
      controllerAs: 'vm'
    })
    .when('/chart-of-account', {
      templateUrl: '/accounting/chart-of-account',
      controller: 'ChartOfAccountController',
      controllerAs: 'vm'
    })
    .otherwise({
      redirectTo: '/company/register'
    });
})
  .config(function (toastrConfig) {
    angular.extend(toastrConfig, {
      positionClass: 'toast-bottom-right'
    });
  });
