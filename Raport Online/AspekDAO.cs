﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    public class AspekDAO
    {
        private OnlineRaporEntities context = new OnlineRaporEntities();

        public AspekDAO()
        {

        }
        //acess modifier , type data keluaran(typeoutput), nama method ,(parameter(typedata , objek)) 
        public int Add(ASPEK aspek)
        {
            var result = 0;
            try
            {
                context.ASPEK.Add(aspek);

                result = context.SaveChanges();

            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int Edit(int id, ASPEK aspek)
        {
            var result = 0;
            try
            {
                
                var exsitingaspek = context.ASPEK.Find(id);
                exsitingaspek.SUB_ASPEK = aspek.SUB_ASPEK;
                exsitingaspek.NAMA_ASPEK = aspek.NAMA_ASPEK;
                exsitingaspek.DIBUAT_OLEH = aspek.DIBUAT_OLEH;
                exsitingaspek.DIBUAT_PADA = aspek.DIBUAT_PADA;
                //context.ASPEK.Add(exsitingaspek);
                result = context.SaveChanges();
            }
            catch
            {
                
                result = -1;
            }

            return result; 
        }


        public ASPEK Detail(int id)
        {
            return context.ASPEK.Find(id);
        }

        public int Delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingaspek = context.ASPEK.Find(id);
                if (!isPermanent)
                {
                    exsitingaspek.DIBUAT_PADA = DateTime.Now;
                    exsitingaspek.STATUS_AKTIF = false;
                }

                else
                {
                    context.ASPEK.Remove(exsitingaspek);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<ASPEK> GetAll()
        {
            return context.ASPEK.ToList();
        }

    }
}