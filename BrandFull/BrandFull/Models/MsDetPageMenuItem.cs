using BrandFull.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BrandFull.Models
{

    public class MsDetPageMenuItem
    {
        public MsDetPageMenuItem()
        {
            TargetType = typeof(MsDetPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string IconUrl { get; set; }
        public string NotifCounts { get; set; }
        public Image embeddedImage { get; set; }
        public Type TargetType { get; set; }
        
    }
}