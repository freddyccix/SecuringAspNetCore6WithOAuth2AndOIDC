﻿using System.ComponentModel.DataAnnotations;

namespace ImageGallery.Client.ViewModels;

public class AddImageViewModel
{
    public AddImageViewModel(string title, List<IFormFile> files)
    {
        Title = title;
        Files = files;
    }

    public AddImageViewModel()
    {
    }

    public List<IFormFile> Files { get; set; } = new();

    [Required] public string Title { get; set; }
}