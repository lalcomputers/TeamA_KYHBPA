﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYHBPA_TeamA.Models
{
    public class AddPhotoViewModel
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public HttpPostedFileBase Image { get; set; } = null;
    }

    public class DisplayPhotosViewModel
    {
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool InPhotoGallery { get; set; }
        public bool IsPartnerOrg { get; set; }
    }

    public class EditPhotosViewModel : DisplayPhotosViewModel
    {
    }

    public class DisplayPartnerOrgViewModel: DisplayPhotosViewModel
    {
    }

    public class PhotoGalleryViewModel
    {
        public List<DisplayPhotosViewModel> Photos { get; set; }
        public List<Event> Events { get; set; }
    }

    public class PartnerOrgViewModel
    {
        public List<DisplayPartnerOrgViewModel> Partners { get; set; }
    }

    public class PartnerOrgViewModel
    {
        public List<DisplayPartnerOrgViewModel> Partners { get; set; }
    }

    public class PartnerOrgViewModel
    {
        public List<DisplayPartnerOrgViewModel> Partners { get; set; }
    }
}