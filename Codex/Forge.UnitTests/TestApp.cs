using Avalonia;
using Avalonia.Headless;
using Avalonia.Themes.Fluent;

[assembly: AvaloniaTestApplication(typeof(Forge.UnitTests.TestApp))]

namespace Forge.UnitTests;

public class TestApp : Application
{
    public override void Initialize()
    {
        // You must load a theme, or the Controls won't have default properties
        Styles.Add(new FluentTheme());
        base.Initialize();
    }

    public static AppBuilder BuildAvaloniaApp() => 
        AppBuilder.Configure<TestApp>()
            .UseHeadless(new AvaloniaHeadlessPlatformOptions());
}