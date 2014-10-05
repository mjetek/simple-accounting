angular.module('accountingApp')
  .controller('JournalController', function (JournalService) {
    this.journal = {
      entries: []
    };

    this.addJournalEntry = function (entry) {
      journal.entries.push(entry);
    };

    this.save = function () {
      JournalService.save(this.journal);
    };
  });