﻿using System.ComponentModel.DataAnnotations;

namespace ImageGallery.Model;

public class ImageForUpdate
{
    public ImageForUpdate(string title)
    {
        Title = title;
    }

    [Required] [MaxLength(150)] public string Title { get; set; }
}