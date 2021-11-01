﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OutlayManagerCore.Persistence.DataBase.EFWithSQLite.EntityModel
{
    public class Transaction : Entity
    {
        public double Amount { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public int CodeTransaction_ID { get; set; }
        public MCodeTransaction CodeTransaction { get; set; }
        public int TypeTransaction_ID { get; set; }
        public MTypeTransaction TypeTransaction { get; set; }
    }
}
