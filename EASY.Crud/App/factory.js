(function () {
    'use strict';

    angular
        .module('app')
        .factory('dataFactory', dataFactory);

    dataFactory.$inject = ['$http'];

    function dataFactory($http) {
        var prefix = "/api/data/";
        var service = {
            helpers: {toCamel:toCamel},
            getKnowledgeBase: getKnowledgeBase,
            getForms: getForms,
            deletePerson: deletePerson,
            postPerson: postPerson
        };

        return service;

        function getForms(successFunc, errorFunc) {
                $http({
                    method: 'GET',
                    url: prefix + "GetForms"
                }).then(successFunc, errorFunc);
        }

        function getKnowledgeBase(successFunc, errorFunc) {
                $http({
                    method: 'GET',
                    url: prefix + "GetKnowledgeBase"
                }).then(successFunc, errorFunc);
        }

        function postPerson(data, successFunc, errorFunc)
        {
            $http({
                method: 'POST',
                url: prefix + "PostPerson",
                data: $.param(data),
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            })
                .then(successFunc, errorFunc);
        }

        function deletePerson(data, successFunc, errorFunc)
        {
            //$http({
            //    method: 'DELETE',
            //    url: prefix + "DeletePerson",
            //    data: data,
            //    //headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            //})
            $http.delete(prefix + "DeletePerson", { params: { id: data.id } })
                .then(successFunc, errorFunc);
        }

        function toCamel(o) {
            var newO, origKey, newKey, value
            if (o instanceof Array) {
                newO = []
                for (origKey in o) {
                    value = o[origKey]
                    if (typeof value === "object") {
                        value = toCamel(value)
                    }
                    newO.push(value)
                }
            } else {
                newO = {}
                for (origKey in o) {
                    if (o.hasOwnProperty(origKey)) {
                        newKey = (origKey.charAt(0).toLowerCase() + origKey.slice(1) || origKey).toString()
                        value = o[origKey]
                        if (value !== null && value.constructor === Object) {
                            value = toCamel(value)
                        }
                        newO[newKey] = value
                    }
                }
            }
            return newO
        }
    }
})();