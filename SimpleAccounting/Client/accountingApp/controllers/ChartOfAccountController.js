angular.module('accountingApp')
  .controller('ChartOfAccountController', function (AccountService, $q) {
    var self = this;
    var init = function () {
      var deferred = $q.defer();

      AccountService.query(function (data) {
        self.accounts = data;
        if (self.types) {
          deferred.resolve();
        }
      });

      AccountService.types(function (data) {
        self.types = data;
        if (self.accounts) {
          deferred.resolve();
        }
      });
      return deferred.promise;
    };

    var buildTree = function () {

    };

    this.typesTree = [{
      name: 'Assets',
      nodes: [
        { name: 'child 1'},
        { name: 'child 2'}
      ]
    }, {
      name: 'Capital',
      nodes: [
        { name: 'child 1'},
        { name: 'child 2', nodes: [ { name: 'child 3' }]}
      ]
    }, {
      name: 'Payable',
      nodes: [
        { name: 'child 1'},
        { name: 'child 2'}
      ]
    }, {
      name: 'Receivable',
      nodes: [
        { name: 'child 1'},
        { name: 'child 2'}
      ]
    }, {
      name: 'Spends',
      nodes: [
        { name: 'child 1'},
        { name: 'child 2'}
      ]
    }];

    this.account = {};
    this.origins = ['Debts', 'Credits'];
    this.categories = ['Real', 'Nominal'];

    this.cancel = function () {

    };

    this.save = function () {

    };
  });
