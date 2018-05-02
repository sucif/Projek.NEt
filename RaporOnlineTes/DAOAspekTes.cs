﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOAspekTes
    {
        AspekDAO aDAO = new AspekDAO();
        [TestMethod]
        public void TestTampilDetailSalah()
        {
            int id = 0;
            ASPEK expectResult = null;
            ASPEK result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]//oktes+db
        public void TestTampilDetailbenar()
        {
            int id = 1;
            ASPEK result = aDAO.Detail(id);

            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestMethodDetailBenar()
        {
            int id = 1;
            ASPEK asp = aDAO.Detail(id);
            Assert.AreEqual("ubah lagi ya", asp.NAMA_ASPEK);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.GetAll());
        }

        //[TestMethod]//oktes+db
        //public void TestTambahAspekbenar()
        //{
        //    ASPEK Asp = new ASPEK();
        //    /*Asp.ID_ASPEK = 1;*/
        //    Asp.NAMA_ASPEK = "aspek";
        //    Asp.DIBUAT_OLEH = "Zakki";
        //    Asp.DIBUAT_PADA = DateTime.Now;
        //    Asp.STATUS_AKTIF = true;
        //    int a = aDAO.Add(Asp);

        //    Assert.IsNotNull(a);

        //}
        [TestMethod]//okpass+db
        public void TambahAspekGagal()
        {
            ASPEK Asp = new ASPEK();
            Asp.ID_ASPEK = 17;
            Asp.NAMA_ASPEK = "aspek";
            Asp.DIBUAT_OLEH = "Zakki";
            Asp.DIBUAT_PADA = DateTime.Now;
            Asp.STATUS_AKTIF = true;
            int a = aDAO.Add(Asp);

            Assert.IsNotNull(a);
        }

        //[TestMethod]
        //public void TambahAspekGagal2()
        //{
        //    ASPEK Asp = new ASPEK();
        //    /*Asp.ID_ASPEK = 1;*/
        //    Asp.NAMA_ASPEK = "aspek";
        //    Asp.DIBUAT_OLEH = "Zakki";
        //    Asp.DIBUAT_PADA = DateTime.Now;
        //    Asp.STATUS_AKTIF = false;
        //    int a=aDAO.Add(Asp);

        //    Assert.IsNull(a);

        //        [TestMethod]
        //        public void EditAspect(int id, ASPEK aspek)
        //        {
        //            if (aspek == null)
        //            {
        //                throw new ArgumentNullException(nameof(aspek));
        //            }
        //            aspek.NAMA_ASPEK = null;
        //            int a = aDAO.Edit(1, aspek);

        //            Assert.IsNotNull(a);
        //        }
        //[TestMethod]//oktess+db
        //public void TesEditAspectbenar()
        //{
        //    ASPEK aspek = aDAO.Detail(2);
        //    Assert.IsNotNull(aspek);
        //    aspek.NAMA_ASPEK = "ubah lagi ya";
        //    aspek.DIUBAH_OLEH = "suci f";
        //    aspek.DIUBAH_PADA = DateTime.Now;
        //    aspek.STATUS_AKTIF = true;
        //    var a = aDAO.Edit(2, aspek);

        //    Assert.AreEqual(1, a);
        //}
        //[TestMethod]//oktess+db
        //public void TesEditAspectSalah()
        //{
        //    ASPEK aspek = aDAO.Detail(0);
        //    Assert.IsNotNull(aspek);
        //    aspek.NAMA_ASPEK = "Komplit pake banget";
        //    aspek.DIUBAH_OLEH = "suci";
        //    aspek.DIUBAH_PADA = DateTime.Now;
        //    aspek.STATUS_AKTIF = true;
        //    var a = aDAO.Edit(0, aspek);

        //    Assert.AreEqual(0, a);
        //}
        //[TestMethod]//oktess+db
        //public void TesEditAspectSalah2()
        //{
        //    ASPEK aspek = aDAO.Detail(2);
        //    Assert.IsNotNull(aspek);
        //    aspek.NAMA_ASPEK = "Komplit pake banget";
        //    aspek.DIUBAH_OLEH = "suci";
        //    aspek.DIUBAH_PADA = DateTime.Now;
        //    aspek.STATUS_AKTIF = true;
        //    var a = aDAO.Edit(2, aspek);

        //    Assert.AreEqual(2, a);
        //}
        [TestMethod]//oktes+db
        public void TesDeleteAspekbenar()
        {
            ASPEK aspek = aDAO.Detail(17);
            Assert.IsNotNull(aspek);
            bool isPermanent = false;

            var a = aDAO.Delete(17, false);
        }
        //[TestMethod]//oktes+db
        //public void TesDeleteAspeksalah()
        //{
        //    ASPEK aspek = aDAO.Detail(4);
        //    Assert.IsNull(aspek);
        //    bool isPermanent = false;

        //    var a = aDAO.Delete(4, true);
        //}
        

    }
}