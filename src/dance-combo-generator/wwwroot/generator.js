(function () {
    var app = angular.module("app", []);

    app.controller("DanceComboGeneratorController", ["$http", "$scope", function ($http, $scope) {
        var vm = this;

        vm.movesInCurrentCombo = [];

        vm.numberOfBeats = 4;

        vm.title = "Combo ";

        //vm.newGameId = "";
        //vm.newName = "";
        //vm.newReleaseYear = "";
        //vm.newRating = "";
        //vm.newPublisher = "";
        //vm.newDescription = "";
        //vm.newGenre = "";

        //vm.editGameId = "";
        //vm.editName = "";
        //vm.editReleaseYear = "";
        //vm.editRating = "";
        //vm.editPublisher = "";
        //vm.editDescription = "";
        //vm.editGenre = "";

        $scope.activate = function () {
            //$http.get("api/Game").then(function (response) {
            //vm.games = response.data;
            //});
        }


        //$scope.generateCombo = function () {
        //    $http({
        //        url: "api/Combo/Generate",
        //        method: "GET",
        //        params: {
        //            numberOfBeats: vm.numberOfBeats
        //        }
        //    }).then(function (response) {
        //        vm.newGameId = response.data.gameId;
        //    });

        //    vm.games.push({
        //        'GameId': vm.newGameId,
        //        'Name': vm.newName,
        //        'ReleaseYear': vm.newReleaseYear,
        //        'Rating': vm.newRating,
        //        'Publisher': vm.newPublisher,
        //        'Description': vm.newDescription,
        //        'Genre': vm.newGenre,
        //    });
        //};

        //$scope.addGame = function () {
        //    $http({
        //        url: "api/Game/Add",
        //        method: "GET",
        //        params: {
        //            name: vm.newName,
        //            releaseYear: vm.newReleaseYear,
        //            rating: vm.newRating,
        //            publisher: vm.newPublisher,
        //            description: vm.newDescription,
        //            genre: vm.newGenre,
        //        }
        //    }).then(function (response) {
        //        vm.newGameId = response.data.gameId;
        //    });

        //    vm.games.push({
        //        'GameId': vm.newGameId,
        //        'Name': vm.newName,
        //        'ReleaseYear': vm.newReleaseYear,
        //        'Rating': vm.newRating,
        //        'Publisher': vm.newPublisher,
        //        'Description': vm.newDescription,
        //        'Genre': vm.newGenre,
        //    });
        //};

        // https://stackoverflow.com/questions/26459525/how-to-modify-and-update-data-table-row-in-angular-js
        $scope.generateCombo = function () {
            $http({
                url: "api/Combo",
                method: "GET",
                params: { numberOfBeats: vm.numberOfBeats }
            }).then(function (response) {
                vm.movesInCurrentCombo = response.data;
                //vm.editGameId = response.data.GameId;
                //vm.editName = response.data.Name;
                //vm.editReleaseYear = response.data.ReleaseYear;
                //vm.editRating = response.data.Rating;
                //vm.editPublisher = response.data.Publisher;
                //vm.editDescription = response.data.Description;
                //vm.editGenre = response.data.Genre;
            });
        };

        //$scope.editGame = function (gameId) {

        //    for (var i = 0; i < vm.games.length; i++) {
        //        var game = vm.games[i];
        //        if (game.GameId == gameId) {
        //            game.Name = vm.editName;
        //            game.ReleaseYear = vm.editReleaseYear;
        //            game.Rating = vm.editRating;
        //            game.Publisher = vm.editPublisher;
        //            game.Description = vm.editDescription;
        //            game.Genre = vm.editGenre;

        //            $http({
        //                url: "api/Edit/Update",
        //                method: "GET",
        //                params: {
        //                    gameId: game.GameId,
        //                    name: game.Name,
        //                    releaseYear: game.ReleaseYear,
        //                    rating: game.Rating,
        //                    publisher: game.Publisher,
        //                    description: game.Description,
        //                    genre: game.Genre
        //                }
        //            }).then(function (response) {
        //                alert('success');
        //            });
        //        }
        //    }
        //};

        ////// https://hello-angularjs.appspot.com/removetablerow
        //$scope.removeGame = function (gameId) {
        //    var index = -1;
        //    var gamesArray = eval(vm.games);
        //    for (var i = 0; i < gamesArray.length; i++) {
        //        if (gamesArray[i].GameId === gameId) {
        //            index = i;
        //            break;
        //        }
        //    }
        //    if (index === -1) {
        //        alert("Something gone wrong");
        //    }
        //    vm.games.splice(index, 1);

        //    $http({
        //        url: "api/Remove",
        //        method: "GET",
        //        params: { gameId: gameId }
        //    });
        //};

        //$scope.editingData = [];

        //for (var i = 0, length = $scope.tabelsData.length; i < length; i++) {
        //    $scope.editingData[$scope.tabelsData[i].id] = false;
        //}

        //$scope.modify = function (tableData) {
        //    $scope.editingData[tableData.id] = true;
        //};


        //$scope.update = function (tableData) {
        //    $scope.editingData[tableData.id] = false;
        //};

        $scope.activate();
        //$scope.submit();
    }]);
}());