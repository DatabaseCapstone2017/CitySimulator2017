using System;
using Xunit;
using DataAccessLayer;
using ServerForTheLogic.DALValidator;
using ServerForTheLogic.DALValidator.ValidationHelper.GridObjectsValidation.BuildingValidation;
using ServerForTheLogic.DALValidator.ValidationHelper;

/// <summary>
/// Unit test for Validators
/// Team: QA
/// Class for unit testing all the validators in DB team Repository
/// 
/// Author: Sean
/// Date: 2017-12-01
/// Based on: N/A
/// Update: N/A
/// </summary>
namespace DataAccessLayer_Test
{ 
        public class ValidatorTest
        {
            /// <summary>
            /// CommercialRetailPrice validator test
            /// Passing maximum int value
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void CommercialValidatorTest_1()
            {
                int testPrice = int.MaxValue;
                Assert.False(CommercialValidator.isValidCommercialRetailPrice(testPrice));
            }

            /// <summary>
            /// CommercialRetailPrice validator test
            /// Passing minimum int value
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void CommercialValidatorTest_2()
            {
                int testPrice = int.MinValue;
                Assert.False(CommercialValidator.isValidCommercialRetailPrice(testPrice));
            }

            /// <summary>
            /// CommercialRetailPrice validator test
            /// Passing 25
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void CommercialValidatorTest_3()
            {
                int testPrice = 25;
                Assert.True(CommercialValidator.isValidCommercialRetailPrice(testPrice));
            }

            /// <summary>
            /// CommercialInventoryCount validator test
            /// Passing maximum int value
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void CommercialValidatorTest_4()
            {
                int testPrice = int.MaxValue;
                Assert.False(CommercialValidator.isValidCommercialInventoryCount(testPrice));
            }

            /// <summary>
            /// CommercialInventoryCount validator test
            /// Passing minimum int value
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void CommercialValidatorTest_5()
            {
                int testPrice = int.MinValue;
                Assert.False(CommercialValidator.isValidCommercialInventoryCount(testPrice));
            }

            /// <summary>
            /// CommercialInventoryCount validator test
            /// Passing 25
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void CommercialValidatorTest_6()
            {
                int testPrice = 25;
                Assert.True(CommercialValidator.isValidCommercialInventoryCount(testPrice));
            }

            /// <summary>
            /// IndustrialInventoryCount validator test
            /// Passing -1
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void IndustrialValidatorTest_1()
            {
                int testPrice = -1;
                Assert.False(IndustrialValidator.isValidIndustrialInventoryCount(testPrice));
            }

            /// <summary>
            /// IndustrialInventoryCount validator test
            /// Passing 1
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void IndustrialValidatorTest_2()
            {
                int testPrice = 1;
                Assert.True(IndustrialValidator.isValidIndustrialInventoryCount(testPrice));
            }

            /// <summary>
            /// IndustrialProductionCost validator test
            /// Passing -1
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void IndustrialValidatorTest_3()
            {
                int testPrice = -1;
                Assert.False(IndustrialValidator.isValidIndustrialProductionCost(testPrice));
            }

            /// <summary>
            /// IndustrialProductionCost validator test
            /// Passing 1
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void IndustrialValidatorTest_4()
            {
                int testPrice = 1;
                Assert.True(IndustrialValidator.isValidIndustrialProductionCost(testPrice));
            }

            /// <summary>
            /// IndustrialWholesalePrice validator test
            /// Passing -1
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void IndustrialValidatorTest_5()
            {
                int testPrice = -1;
                Assert.False(IndustrialValidator.isValidIndustrialWholesalePrice(testPrice));
            }

            /// <summary>
            /// IndustrialWholesalePrice validator test
            /// Passing 1
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void IndustrialValidatorTest_6()
            {
                int testPrice = 1;
                Assert.True(IndustrialValidator.isValidIndustrialWholesalePrice(testPrice));
            }

            /// <summary>
            /// BuildingRating validator test
            /// Passing 0
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void BuildingValidatorTest_1()
            {
                int testRating = -1;
                Assert.False(BuildingValidator.isValidBuildingRating(testRating));
            }

            /// <summary>
            /// BuildingRating validator test
            /// Passing 4
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void BuildingValidatorTest_2()
            {
                int testRating = 4;
                Assert.False(BuildingValidator.isValidBuildingRating(testRating));
            }

            /// <summary>
            /// BuildingRating validator test
            /// Passing 2
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void BuildingValidatorTest_3()
            {
                int testRating = 2;
                Assert.True(BuildingValidator.isValidBuildingCapacity(testRating));
            }

            /// <summary>
            /// BuildingCapacity validator test
            /// Passing 0
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void BuildingValidatorTest_4()
            {
                int testRating = -1;
                Assert.False(BuildingValidator.isValidBuildingCapacity(testRating));
            }

            /// <summary>
            /// BuildingCapacity validator test
            /// Passing 101
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void BuildingValidatorTest_5()
            {
                int testRating = 101;
                Assert.False(BuildingValidator.isValidBuildingCapacity(testRating));
            }

            /// <summary>
            /// BuildingCapacity validator test
            /// Passing 50
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void BuildingValidatorTest_6()
            {
                int testRating = 50;
                Assert.True(BuildingValidator.isValidBuildingCapacity(testRating));
            }

            /// <summary>
            /// ValidGuid validator test
            /// Passing a GUID created using Visual Studio
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void GridObjectValidatorTest_1()
            {
                Assert.True(GridObjectValidator.isValidGuid("43B32FF8-B619-4ABF-BEB8-91DFC43DCD96"));
            }

            /// <summary>
            /// ValidGuid validator test
            /// Passing a invalid GUID
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void GridObjectValidatorTest_2()
            {
                Assert.False(GridObjectValidator.isValidGuid("43B32FF8-B619-4ABF-EEEEE-91DFC43DCD96"));
            }

            /// <summary>
            /// ValidXCoordinate validator test
            /// Passing a invalid X Coordinate
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void GridObjectValidatorTest_3()
            {
                int testCord = -1;
                Assert.False(GridObjectValidator.isValidXCoordinate(testCord));
            }

            /// <summary>
            /// ValidXCoordinate validator test
            /// Passing a valid X Coordinate
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void GridObjectValidatorTest_4()
            {
                int testCord = 1;
                Assert.True(GridObjectValidator.isValidXCoordinate(testCord));
            }

            /// <summary>
            /// ValidYCoordinate validator test
            /// Passing a invalid Y Coordinate
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void GridObjectValidatorTest_5()
            {
                int testCord = -1;
                Assert.False(GridObjectValidator.isValidYCoordinate(testCord));
            }

            /// <summary>
            /// ValidYCoordinate validator test
            /// Passing a valid Y Coordinate
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void GridObjectValidatorTest_6()
            {
                int testCord = 1;
                Assert.True(GridObjectValidator.isValidYCoordinate(testCord));
            }

            /// <summary>
            /// ValidProductName validator test
            /// Passing an invalid name
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ProductValidatorTest_1()
            {
                string testName = "";
                Assert.False(ProductValidator.isValidProductName(testName));
            }

            /// <summary>
            /// ValidProductName validator test
            /// Passing an invalid name
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ProductValidatorTest_2()
            {
                string testName = null;
                Assert.False(ProductValidator.isValidProductName(testName));
            }

            /// <summary>
            /// ValidProductName validator test
            /// Passing an invalid name
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ProductValidatorTest_3()
            {
                string testName = "this string is 30 characters long so it should be invalid";
                Assert.False(ProductValidator.isValidProductName(testName));
            }

            /// <summary>
            /// ValidProductName validator test
            /// Passing an valid name
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ProductValidatorTest_4()
            {
                string testName = "Sean";
                Assert.True(ProductValidator.isValidProductName(testName));
            }

            /// <summary>
            /// ValidProductGlobalCount validator test
            /// Passing an invalid count
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ProductValidatorTest_5()
            {
                int testCount = int.MaxValue;
                Assert.False(ProductValidator.isValidProductGlobalCount(testCount));
            }

            /// <summary>
            /// ValidProductGlobalCount validator test
            /// Passing an invalid count
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ProductValidatorTest_6()
            {
                int testCount = int.MinValue;
                Assert.False(ProductValidator.isValidProductGlobalCount(testCount));
            }

            /// <summary>
            /// ValidProductGlobalCount validator test
            /// Passing an valid count
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ProductValidatorTest_7()
            {
                int testCount = 25;
                Assert.True(ProductValidator.isValidProductGlobalCount(testCount));
            }

            /// <summary>
            /// ValidClockNetMinutes validator test
            /// Passing an invalid minutes
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_1()
            {
                UInt32 testValue = 0;
                Assert.True(ClockValidator.isValidClockNetMinutes(testValue));
            }

            /// <summary>
            /// ValidClockNetMinutes validator test
            /// Passing an invalid minutes
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_2()
            {
                UInt32 testValue = 60;
                Assert.False(ClockValidator.isValidClockNetMinutes(testValue));
            }

            /// <summary>
            /// ValidClockNetMinutes validator test
            /// Passing an valid minutes
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_3()
            {
                UInt32 testValue = 30;
                Assert.True(ClockValidator.isValidClockNetMinutes(testValue));
            }

            /// <summary>
            /// ValidClockNetHours validator test
            /// Passing an invalid hours
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_4()
            {
                UInt32 testValue = 0;
                Assert.True(ClockValidator.isValidClockNetHours(testValue));
            }

            /// <summary>
            /// ValidClockNetHours validator test
            /// Passing an invalid hours
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_5()
            {
                UInt32 testValue = 24;
                Assert.False(ClockValidator.isValidClockNetHours(testValue));
            }

            /// <summary>
            /// ValidClockNetHours validator test
            /// Passing an valid hours
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_6()
            {
                UInt32 testValue = 12;
                Assert.True(ClockValidator.isValidClockNetHours(testValue));
            }

            /// <summary>
            /// ValidClockNetDays validator test
            /// Passing an invalid days
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_7()
            {
                UInt32 testValue = 0;
                Assert.True(ClockValidator.isValidClockNetDays(testValue));
            }

            /// <summary>
            /// ValidClockNetDays validator test
            /// Passing an invalid days
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_8()
            {
                UInt32 testValue = 366;
                Assert.False(ClockValidator.isValidClockNetDays(testValue));
            }

            /// <summary>
            /// ValidClockNetDays validator test
            /// Passing an valid days
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_9()
            {
                UInt32 testValue = 29;
                Assert.True(ClockValidator.isValidClockNetDays(testValue));
            }

            /// <summary>
            /// ValidClockNetYears validator test
            /// Passing an invalid years
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_10()
            {
                UInt32 testValue = 0;
                Assert.True(ClockValidator.isValidClockNetYears(testValue));
            }

            /// <summary>
            /// ValidClockNetYears validator test
            /// Passing an invalid years
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_11()
            {
                UInt32 testValue = int.MaxValue;
                Assert.True(ClockValidator.isValidClockNetYears(testValue));
            }

            /// <summary>
            /// ValidClockNetYears validator test
            /// Passing an valid years
            /// 
            /// Author: Sean
            /// Date: 2017-12-01
            /// </summary>
            [Fact]
            public void ClockValidatorTest_12()
            {
                UInt32 testValue = 29;
                Assert.True(ClockValidator.isValidClockNetYears(testValue));
            }

        }
    }

