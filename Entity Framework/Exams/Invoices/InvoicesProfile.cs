﻿using AutoMapper;
using Invoices.Data.Models;
using Invoices.DataProcessor.ImportDto;

namespace Invoices
{
    public class InvoicesProfile : Profile
    {
        public InvoicesProfile()
        {
            CreateMap<Invoice, InvoiceDTO>();

            CreateMap<Product, ProductDTO>();
        }
    }
}
