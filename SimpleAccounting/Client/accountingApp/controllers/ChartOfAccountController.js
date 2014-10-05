angular.module('accountingApp')
  .controller('ChartOfAccountController', function (AccountService) {

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

    this.accounts = [];
    this.origins = ['Debts', 'Credits'];
    this.categories = ['Real', 'Nominal'];
    this.types = [];

    this.cancel = function () {

    };

    this.save = function () {

    };
  });
