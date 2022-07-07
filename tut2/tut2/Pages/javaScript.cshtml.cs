using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tut2.Pages
{
    public class javaScriptModel : PageModel
    {
      
        public void OnGet(String s)
        {

        }

        public static String toTitle(String s)
        {
            // Change s to 'Title Case Like This'

            // create myTI
            TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
            
            // return Title Case Version of s
            return myTI.ToTitleCase( s );
        }
    }
}
