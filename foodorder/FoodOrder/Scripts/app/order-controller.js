angular.module('FoodOrderApp', [])
	.controller('OrderController', function($scope, $http) {
		$scope.title = "loading ...";

		$scope.init = function() {
			$http.get("/api/order").success(function(data, status, headers, config) {
				$scope.order = data;
			}).error(function(data, status, headers, config) {
				$scope.title = "Oops... something went wrong";
			});
		};
		$scope.save = function (order) {
			$http.post('/api/order', { 'name': order.name, 'price': order.price, 'category': order.category }).success(function (data, status, headers, config) {
				alert("Saved!!!");
			}).error(function(data, status, headers, config) {
				$scope.title = "Oops... something went wrong";
			});
		};
	});