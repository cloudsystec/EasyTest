(function() {
    'use strict';

    angular.module('app').controller('baseController', baseController);

    baseController.$inject = ['$location', '$scope', 'SweetAlert', 'dataFactory'];

    function baseController($location, $scope, SweetAlert, dataFactory) {
        /* jshint validthis:true */
        var vm = this;

        vm.submitInfo = function() {
            dataFactory.postPerson(vm.person, function (data)
            {
                vm.step = 1;
                vm.person = {
                    disponibility: 0,
                    bestTime: 0,
                    bankInfo: {},
                    knowledges: [],
                    knowledgeBase: []
                };
                $location.path("/persons");
                SweetAlert.swal("", data.data, "success");
            });
        }

        activate();

        function activate() {
            vm.step = 1;
            vm.title = 'controller';
            vm.person = {
                disponibility: 0,
                bestTime: 0,
                bankInfo: {},
                knowledges: [],
                knowledgeBase: []
            };

            dataFactory.getKnowledgeBase(function(data) {
                vm.person.knowledgeBase = data.data;
            });
        }
    }
})();
