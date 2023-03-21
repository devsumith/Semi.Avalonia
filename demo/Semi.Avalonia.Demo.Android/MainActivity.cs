using Android.App;
using Android.Content.PM;
using Avalonia.Android;

namespace Semi.Avalonia.Demo.Android;

[Activity(Label = "Semi.Avalonia.Demo.Android", Icon = "@drawable/Icon", Theme = "@style/MyTheme.NoActionBar",
    LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
public class MainActivity : AvaloniaMainActivity
{
    
}