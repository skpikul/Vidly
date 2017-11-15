﻿using ERPTP.Models;
using System.Collections.Generic;

namespace ERPTP.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}