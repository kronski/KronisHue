﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KronisHueWeb.Pages
{
    public class AuthModel : PageModel
    {
        public void OnGet()
        {
            Response.Headers["Access-Control-Allow-Origin"]="https://localhost:5001";
            
        }
    }
}