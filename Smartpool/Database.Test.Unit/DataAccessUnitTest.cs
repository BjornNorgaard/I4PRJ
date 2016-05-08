﻿using NUnit.Framework;
using Smartpool;
using Smartpool.DataAccess;

namespace Database.Test.Unit
{
    [TestFixture]
    public class DataAccessUnitTest
    {
        #region Setup

        private IWriteDataAccess _uut;
        private IUserAccess _userAccess;
        private IPoolAccess _poolAccess;

        string email = "hansen@gmail.com", poolname = "baghave";

        [SetUp]
        public void Setup()
        {
            _uut = new DataAccess();
            _userAccess = new UserAccess();
            _poolAccess = new PoolAccess(_userAccess);

            _userAccess.AddUser("Sir Derp Hansen", email, "hanpassword");
            _poolAccess.AddPool(email, poolname, 8);
            _uut.AddData(email, poolname);
        }

        [TearDown]
        public void Teardown()
        {
            _poolAccess.DeleteAllPools();
            _userAccess.DeleteAllUsers();
            _uut.DeleteAllData();
        }

        #endregion

        #region AddData

        [Test]
        public void AddData_AddingDataToNonExistingPoolAndUser_ReturnsFalse()
        {
            Assert.That(_uut.AddData(email, poolname), Is.False);
        }

        [Test]
        public void AddData_AddingDataToNonExistingPool_ReturnsFalse() { }

        [Test]
        public void AddData_AddingDataToNonExistingUser_ReturnsFalse() { }

        [Test]
        public void AddData_AddingDataToPoolWithExistingData_ReturnsFalse() { }

        [Test]
        public void AddData_AddingData_ReturnsFalse() { }

        #endregion

        #region RemoveData

        [Test]
        public void RemoveData_RemovingDataFromNonExistingPoolAndUser_ReturnsFalse() { }

        [Test]
        public void RemoveData_RemovingDataFromNonExistingPool_ReturnsFalse() { }

        [Test]
        public void RemoveData_RemovingDataFromNonExistingUser_ReturnsFalse() { }

        [Test]
        public void RemoveData_RemovingDataFromPoolWithoutData_ReturnsFalse() { }

        [Test]
        public void RemoveData_RemovingData_ReturnsFalse() { }

        #endregion

        #region DeleteAllData

        [Test]
        public void DeleteAllData_AddedDataToSomePools_NoDataSetInDatabase() { }

        [Test]
        public void DeleteAllData_EmptyDatabase_NoDataSetInDatabase() { }

        #endregion

    }
}