using DALL_E_Challenge_NET_MAUI.Models;
using System.Collections.ObjectModel;

namespace DALL_E_Challenge_NET_MAUI.Views;

public partial class DashboardView : ContentPage
{
    public ObservableCollection<Profile> Profiles { get; set; }
    public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }
    public DashboardView()
    {
        InitializeComponent();
        LoadData();
        BindingContext = this;
    }

    private void LoadData()
    {
        Profiles = new ObservableCollection<Profile>()
        {
            new Profile
            {
                Name = "Raccoon",
                ProfileImage = "profile1.jpg",
                NoPhotos = 5
            },
            new Profile
            {
                Name = "Hank",
                ProfileImage = "profile2.jpg",
                NoPhotos = 12
            },
            new Profile
            {
                Name = "X-183",
                ProfileImage = "profile3.jpg",
                NoPhotos = 7
            },
            new Profile
            {
                Name = "Y-184",
                ProfileImage = "profile4.jpg",
                NoPhotos = 3
            },
        };
        GeneratedImages = new ObservableCollection<GeneratedImage>()
        {
            new GeneratedImage
            {
                ImagePath = "dashboard1.jpg",
                MainKeyword = "Forest",
                Keywords = new List<string>
                {
                    "forest, sun, trees, moss, nature"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard2.jpg",
                MainKeyword = "Mountains",
                Keywords = new List<string>
                {
                    "mountains, lake, clouds, nature, light"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard3.jpg",
                MainKeyword = "Ocean",
                Keywords = new List<string>
                {
                    "ocean, depth, trident, fish"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard4.jpg",
                MainKeyword = "Robot",
                Keywords = new List<string>
                {
                    "works, science, programming, mechanics"
                }
            }
        };
    }
}