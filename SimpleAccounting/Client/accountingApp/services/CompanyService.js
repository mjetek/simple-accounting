angular.module('accountingApp')
  .factory('CompanyService', function ($resource) {
    return $resource('/api/companyapi/:id', {
      id: '@id'
    }, {
      register: {
        method: 'POST',
        url: '/api/companyapi/register'
      },
      addUser: {
        method: 'POST',
        url: '/api/companyapi/add-user'
      }
    });
  });

