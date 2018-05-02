﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    public class WilayahDAO
    {
        private OnlineRaporEntities context = new OnlineRaporEntities();

        public WilayahDAO()
        {

        }

        public int Add(WILAYAH wilayah)
        {
            var result = 0;
            try
            {
                context.WILAYAH.Add(wilayah);
                result=context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int Edit(int id, WILAYAH wilayah)
        {
            var result = 0;
            try
            {
                var exsitingwilayah = context.WILAYAH.Find(id);
                exsitingwilayah.WILAYAH1 = wilayah.WILAYAH1;
                exsitingwilayah.WILAYAH2 = wilayah.WILAYAH2;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public WILAYAH Detail(int id)
        {
            return context.WILAYAH.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingwilayah = context.WILAYAH.Find(id);
                if (!isPermanent)
                {
                    exsitingwilayah.DIUBAH_PADA = DateTime.Now;
                    exsitingwilayah.STATUS_AKTIF = false;
                }

                else
                {
                    context.WILAYAH.Remove(exsitingwilayah);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<WILAYAH> GetAll()
        {
            return context.WILAYAH.ToList();
        }

    }
}
