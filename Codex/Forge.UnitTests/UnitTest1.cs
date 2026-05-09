using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Headless.NUnit;
using Avalonia.Media;
using Forge.Models;

namespace Forge.UnitTests;

[TestFixture]
public class XamlRoundTripTests
{
    [AvaloniaTest]
    [NUnit.Framework.Description("Verifies that a user-designed element survives the XAML serialization process.")]
    public void Should_Restore_Button_Properties_From_Generated_Xaml()
    {
        // 1. Arrange: Simulate a user designing a button in your Level Builder
        var designSessionButton = new ForgeButton
        {
            Content = "Cast Fireball",
            BackgroundColor = Brushes.OrangeRed.ToString(),
            Width = 150,
            Height = 50
        };
        
        // 2. Act: Forge the string (The Library logic)
        string xaml = XamlForge.SerializeToXaml(designSessionButton);

        // 3. Act: Inflate the string back into a live object
        var inflatedButton = XamlForge.LoadFromXaml<ForgeButton>(xaml);

        // 4. Assert: Use NUnit constraint syntax
        Assert.Multiple(() =>
        {
            Assert.That(inflatedButton, Is.Not.Null);
            Assert.That(inflatedButton.Content, Is.EqualTo("Cast Fireball"));
            Assert.That(inflatedButton.BackgroundColor, Is.EqualTo(Brushes.OrangeRed.ToString()));
            Assert.That(inflatedButton.Width, Is.EqualTo(150));
            Assert.That(inflatedButton.Height, Is.EqualTo(50));
        });
    }
}