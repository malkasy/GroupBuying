(function () {
  'use strict';

  angular.module('CollectiveP.pages.home', [])
      .config(routeConfig);

  /** @ngInject */
  function routeConfig($stateProvider) {
  $stateProvider
        .state('home', {
            url: '/home',
            templateUrl: 'app/pages/home/home.html',
            title: 'Home',
            controller: "HomeCtrl",
          sidebarMeta: {
            order: 100,
            icon: 'ion-android-home'
          },
        });
  }

})();