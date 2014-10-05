angular.module('accountingApp')
  .controller('AddUserController', function (CompanyService, $modalInstance, toastr, companyId) {
    this.user = {
      companyId: companyId
    };

    this.save = function () {
      CompanyService.addUser(this.user, function (user) {
        toastr.success('User ' + user.userName + ' has been saved');
        $modalInstance.close(user);
      }, function () {
        toastr.error('An error occured while saving a user.');
      });
    };

    this.cancel = function () {
      $modalInstance.dismiss('cancel');
    }
  });