﻿using OutlayManagerCore.Model.Transaction;
using System;

namespace OutlayManagerCore.Persistence.DataBase.EFWithSQLite.Utilities
{
    internal static class Casting
    {
        public static TransactionDTO ToTransactionDTO(this EntityModel.Transaction entityTransaction)
        {
            return (entityTransaction == null) 
                            ? new Model.Transaction.TransactionDTO() 
                            : new Model.Transaction.TransactionDTO()
                            {
                                ID = (uint)entityTransaction.ID,
                                Amount = entityTransaction.Amount,
                                Date = entityTransaction.Date.ToDateTime(),
                                CodeTransaction  = entityTransaction.CodeTransaction?.Code,
                                CodeTransactionID = entityTransaction.CodeTransaction_ID,
                                TypeTransaction = entityTransaction.TypeTransaction?.Type,
                                TypeTransactionID = entityTransaction.TypeTransaction_ID,
                                Description = entityTransaction.Description
                            };
        }
        
        public static CodeTransactionDTO ToCodeTransactionDTO(this EntityModel.MCodeTransaction entityCodeTransaction)
        {
            return (entityCodeTransaction == null)
                        ? new CodeTransactionDTO()
                        : new CodeTransactionDTO()
                        {
                            ID = entityCodeTransaction.ID,
                            Code = entityCodeTransaction.Code
                        };

        }

        public static TypeTransactionDTO ToTypeTransactionDTO(this EntityModel.MTypeTransaction entityTypeTransaction)
        {
            return (entityTypeTransaction == null)
                        ? new TypeTransactionDTO()
                        : new TypeTransactionDTO()
                        {
                            ID = entityTypeTransaction.ID,
                            Type = entityTypeTransaction.Type
                        };

        }
    }
}
