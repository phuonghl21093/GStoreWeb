﻿//create by BienLV2
//15-07-2014
//services use to product type service
'use strict';
web365app.factory('languageService', ['$q', '$http', 'baseService', function ($q, $http, baseService) {

    var layoutContentService = {};

    //function get list product type
    var _getList = function (obj) {

        var deferred = $q.defer();

        //get data from services
        $http.get('/Language/GetList', {
            params: obj
        }).success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    //function get list for tree
    var _getListForTree = function () {

        var deferred = $q.defer();

        //get data from services
        $http.get('/Language/GetListForTree').success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    var _getPropertyFilter = function () {

        var deferred = $q.defer();

        //get data from services
        $http.get('/Language/GetPropertyFilter').success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    //function get detail form picture type
    var _getDetailForm = function (id) {

        var deferred = $q.defer();

        //get data from services
        $http.get('/Language/Detail', {
            params: {
                id: id
            }
        }).success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    //function get edit form product type
    var _getEditForm = function (id) {

        var deferred = $q.defer();

        //get data from services
        $http.get('/Language/EditForm', {
            params: {
                id: id
            }
        }).success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    //function get edit form product type
    var _modified = function (obj) {

        var deferred = $q.defer();

        //get data from services
        $http.post('/Language/Action', obj, {
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
        }).success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    var _showAll = function (listId) {

        var deferred = $q.defer();

        $http.post('/Language/ShowAll', {
            listId: listId
        }).success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    var _hideAll = function (listId) {

        var deferred = $q.defer();

        $http.post('/Language/HideAll', {
            listId: listId
        }).success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    var _deleteAll = function (listId) {

        var deferred = $q.defer();

        $http.post('/Language/Delete', {
            listId: listId
        }).success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    var _nameExist = function (id, name) {

        var deferred = $q.defer();

        $http.post('/Language/NameExist', {
            id: id,
            name: name
        }).success(function (data) {
            deferred.resolve(data);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    layoutContentService.getList = _getList;
    layoutContentService.getListForTree = _getListForTree;
    layoutContentService.getPropertyFilter = _getPropertyFilter;
    layoutContentService.getDetailForm = _getDetailForm;
    layoutContentService.getEditForm = _getEditForm;
    layoutContentService.modified = _modified;
    layoutContentService.showAll = _showAll;
    layoutContentService.hideAll = _hideAll;
    layoutContentService.deleteAll = _deleteAll;
    layoutContentService.nameExist = _nameExist;

    return layoutContentService;
}]);