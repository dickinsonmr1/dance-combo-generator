(function () {
    var app = angular.module("app", []);

    app.controller("DanceComboGeneratorController", ["$http", "$scope", function ($http, $scope) {
        var vm = this;

        vm.movesInCurrentCombo = [];

        vm.numberOfBeats = 4;

        vm.title = "Combo ";

        $scope.activate = function () {

        }

        // https://stackoverflow.com/questions/26459525/how-to-modify-and-update-data-table-row-in-angular-js
        $scope.generateComboForMoves = function () {
            var numMoves = $('#slider1Val').text();
            var difficultyLevel = $('#slider2Val').text();
            $http({
                url: "api/Combo",
                method: "GET",
                params: {
                    numberOfMoves: numMoves,
                    difficultyLevel: difficultyLevel
                }
            }).then(function (response) {
                vm.movesInCurrentCombo = response.data;
            });
        };

        $scope.generateComboForBeats = function () {
            var difficultyLevel = $('#slider2Val').text();
            var numBeats = $('#slider3Val').text();
            $http({
                url: "api/combobeats",
                method: "GET",
                params: {
                    numberOfBeats: numBeats,
                    difficultyLevel: difficultyLevel
                }
            }).then(function (response) {
                vm.movesInCurrentCombo = response.data;
            });
        };

        $scope.activate();
    }]);    
}());
