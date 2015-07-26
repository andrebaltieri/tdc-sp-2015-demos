(function () {
    'use strict';
    angular.module('abt').controller('StudentCreateController', StudentCreateController);

    StudentCreateController.$inject = ['$http','$location'];

    function StudentCreateController($http, $location) {
        var vm = this;
        vm.student = {
            Name: '',
            Email: ''
        };

        activate();

        function activate() {
        }

        vm.submit = function () {
            $http.post('api/students', vm.student).success(function (res) {
                toastr.success(vm.student.name + ' incluido com sucesso', 'Sucesso');
                $location.path('/students');
            });
        };
    }
})();