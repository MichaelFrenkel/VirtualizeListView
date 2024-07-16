using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Sample.CrashRepro;

public partial class CrashReproViewModel : ObservableObject
{
    private readonly Random _rnd = new();
    private readonly Random _heightRnd = new();
    
    [ObservableProperty]
    private string _query;

    [ObservableProperty]
    private List<CrashReproItem> _items;

    partial void OnQueryChanged(string value)
    {
        var items = new List<CrashReproItem>();
        if (!string.IsNullOrWhiteSpace(value))
        {
            var count = _rnd.Next(10, 50);
            for (var i = 0; i < count; i++)
                items.Add(new CrashReproItem
                {
                    Title = $"Item #{i}",
                    Description = value,
                    Height = _heightRnd.Next(50, 100),
                    ImageUrl = "https://picsum.photos/600"
                });
        }

        Items = items;
    }
}