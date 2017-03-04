(function() {
    'use strict';

    angular.module('app').controller('personController', personController);

    personController.$inject = ['$location', '$scope', '$mdDialog', 'SweetAlert', 'dataFactory'];

    function personController($location,$scope, $mdDialog, SweetAlert, dataFactory) {
        /* jshint validthis:true */
        var vm = this;
        //SweetAlert.swal("", data.data, "success");

        activate();

        function activate() {
            var allKnowBase = [];

            dataFactory.getForms(function (data) {
                $scope.persons = dataFactory.helpers.toCamel(data.data);
            });

            dataFactory.getKnowledgeBase(function (data) {
                allKnowBase = data.data;
            });

            $scope.deletePerson = function(person, event) {
                SweetAlert.swal({
                        title: "Deseja realmente deletar este formulário ?", 
                        text: "não é possivel reverter esta ação.", 
                        type: "warning", 
                        showCancelButton: true,
                        confirmButtonColor: "#DD6B55",
                        confirmButtonText: "Confirmar",
                        cancelButtonText: "Cancelar",
                        closeOnConfirm: false,
                        closeOnCancel: true
                    },
                    function(isConfirm) { 
                        if (isConfirm) {
                            dataFactory.deletePerson({ id: person.id}, function (data) {
                                SweetAlert.swal("", data.data, "success");
                                $scope.persons.splice($scope.persons.indexOf(person), 1);
                            });
                        }
                    });
            };

            $scope.goToPerson = function (person, event,tmpl) {
                $scope.person = person;
                $scope.person.hourlySalary = parseInt(person.hourlySalary);
                $scope.person.knowledgeBase = allKnowBase;

                $mdDialog.show({
                    clickOutsideToClose: true,
                    scope: $scope, 
                    preserveScope: true,
                        templateUrl: tmpl,
                    controller: function editPersonController($scope, $mdDialog)
                    {
                        $scope.editPerson = function() {
                            dataFactory.postPerson($scope.person, function (data) {
                                SweetAlert.swal("", data.data, "success");
                                $scope.closeDialog();
                            });
                        }

                        $scope.closeDialog = function() {
                            $mdDialog.hide();
                        }
                    }
                });
            }

            $scope.goToBank = function (person, event) {
                $scope.person = person;
                $scope.person.hourlySalary = parseInt(person.hourlySalary);

                $mdDialog.show({
                    clickOutsideToClose: true,
                    scope: $scope, 
                    preserveScope: true,
                    templateUrl: 'bankEdit.html',
                    controller: function editPersonController($scope, $mdDialog)
                    {
                        $scope.editBanck = function () {
                            dataFactory.postPerson($scope.person, function (data) {
                                SweetAlert.swal("", data.data, "success");
                                $scope.closeDialog();
                            });
                        }

                        $scope.closeDialog = function() {
                            $mdDialog.hide();
                        }
                    }
                });
            }
        }
    }
})();
