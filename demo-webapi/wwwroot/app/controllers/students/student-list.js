(function () {
    'use strict';
    angular.module('abt').controller('StudentController', StudentController);

    StudentController.$inject = ['$http'];

    function StudentController($http) {
        var vm = this;
        vm.students = [];
        
        activate();

        function activate() {
            $http.get('api/students').success(function (res) {
                angular.forEach(res, function(item) {
                    vm.students.push(item);
                });
            });
        }
    }
})();