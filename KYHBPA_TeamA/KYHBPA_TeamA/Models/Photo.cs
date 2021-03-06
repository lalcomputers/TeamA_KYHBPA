﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYHBPA_TeamA.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string PhotoTitle { get; set; }
        public string PhotoDesc { get; set; }
        public DateTime TimeStamp { get; set; }
        public byte[] ThumbnailPhotoContent { get; set; }
        public byte[] PhotoData { get; set; }
        public string MimeType { get; set; }
        public bool InLandingPageCarousel { get; set; }
        public bool InPartnerOrgCarousel { get; set; }
        public bool InPhotoGallery { get; set; }
        public string Link { get; set; }
        public string Credit { get; set; }
    }
}