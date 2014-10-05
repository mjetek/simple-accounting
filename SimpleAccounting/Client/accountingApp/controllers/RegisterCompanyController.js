angular.module('accountingApp')
  .controller('RegisterCompanyController', function (CompanyService, $modal, toastr) {
    var self = this;
    self.company = {
    };

    this.register = function () {
      CompanyService.register(this.company, function (company) {
        self.company.id = company.id;
        toastr.success('Company ' + company.name + ' has been saved');
      }, function () {
        toastr.error('An error occured while saving a company.');
      });
    };

    this.cancel = function () {
      return console.log('cancel');
    };

    this.addUser = function () {
      var modalInstance = $modal.open({
        templateUrl: '/company/adduser',
        controller: 'AddUserController',
        controllerAs: 'vm',
        size: 'lg',
        resolve: {
          companyId: function () {
            return self.company.id
          }
        }
      });

      modalInstance.result.then(function (userId) {
        //userId - id of saved user.
      });
    };
  });
