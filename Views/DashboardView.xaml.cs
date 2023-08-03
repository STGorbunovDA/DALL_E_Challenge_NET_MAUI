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
                Name = "Bidgo",
                ProfileImage = "profile1.jpg",
                NoPhotos = 5
            },
            new Profile
            {
                Name = "Gorin",
                ProfileImage = "profile2.jpg",
                NoPhotos = 12
            },
            new Profile
            {
                Name = "Bratello",
                ProfileImage = "profile3.jpg",
                NoPhotos = 7
            },
            new Profile
            {
                Name = "Sanchaz",
                ProfileImage = "profile4.jpg",
                NoPhotos = 3
            },
        };
        GeneratedImages = new ObservableCollection<GeneratedImage>()
        {
            new GeneratedImage
            {
                ImagePath = "dashboard1.jpg",
                MainKeyword = "Indian",
                Keywords = new List<string>
                {
                    "bow, arrows, indians, mountain, asians"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard2.jpg",
                MainKeyword = "Bodybuilding",
                Keywords = new List<string>
                {
                    "rocking chair, golubochkin, gym, sports"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard3.jpg",
                MainKeyword = "Comedia",
                Keywords = new List<string>
                {
                    "kazakhstan, armenia, shurik, caucasian captive"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard4.jpg",
                MainKeyword = "Utkin",
                Keywords = new List<string>
                {
                    "fat, fat, burger, joke, second chin"
                }
            }
        };
    }
}