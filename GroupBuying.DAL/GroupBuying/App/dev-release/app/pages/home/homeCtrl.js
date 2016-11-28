/**
 * @author v.lugovksy
 * created on 16.12.2015
 */
(function () {
    'use strict';

    angular.module('CollectiveP.pages.home')
        .controller('HomeCtrl', HomeCtrl);

    /** @ngInject */
    function HomeCtrl($scope, baConfig,$http) {
        $http({
            url: '/home/index',
            method: 'GET'
        }).then(function (data, status) {
            $scope.items = data.data;
        },
        function (response) {
            $scope.res = response;

        });
       
    }
})();