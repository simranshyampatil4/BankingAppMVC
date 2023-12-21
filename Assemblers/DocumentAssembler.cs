using BankingAppMVC.Models;
using BankingAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.Assemblers
{
    public class DocumentAssembler
    {
        public Document ConvertToModel(DocumentVM documentVM)
        {
            return new Document()
            {
                Id = documentVM.Id,
                DocumentName = documentVM.DocumentName,
                DocumentFile = documentVM.DocumentFile,
                Customer = new Customer() { Id = documentVM.CustomerId },
            };
        }
        public DocumentVM ConvertToViewModel(Document document)
        {
            return new DocumentVM()
            {
                Id = document.Id,
                DocumentName = document.DocumentName,
                DocumentFile = document.DocumentFile,
                CustomerId = document.Customer.Id,
            };
        }
    }
}