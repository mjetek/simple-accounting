angular.module('accountingApp')
  .factory('AccountService', function ($resource) {
    return $resource('/api/accountsapi/get/:id', {
      id: '@id'
    }, {
      query: {
        url: '/api/accountsapi/getall',
        isArray: true
      },
      types: {
        url: '/api/accountsapi/types',
        isArray: true
      }
    });
  });
