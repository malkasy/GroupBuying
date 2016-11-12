(function () {
  'use strict';

  angular.module('CollectiveP.pages.home', [])
      .config(routeConfig);

  /** @ngInject */
  function routeConfig() {
  $stateProvider
        .state('home', {
            url: '/home',
            templateUrl: 'app/pages/home/home.html',
            title: 'Home',
          sidebarMeta: {
            order: 800,
          },
        });
  }

})();