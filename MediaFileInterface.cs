﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_meediakogu
{
    public interface MediaFileInterface
    {
        public string FileName { get; set; }
        public decimal FileSize { get; set; }
        public void Open()
        {

        }
        public void Delete()
        {

        }
        public void Copy()
        {

        }
        public void Rename()
        {

        }
        public void OpenProperties()
        {

        }
    }
}
