using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;

using Xunit;
namespace AutomationTests.UI;
public class Tests : TestBase
{
    [Fact]
    public async Task MyTest()
    {
        await _page.GotoAsync("https://demoqa.com/automation-practice-form");

        await _page.GetByRole(AriaRole.Textbox, new() { Name = "First Name" }).ClickAsync();
        await _page.GetByRole(AriaRole.Textbox, new() { Name = "First Name" }).FillAsync("Debasis");

        await _page.GetByRole(AriaRole.Textbox, new() { Name = "Last Name" }).ClickAsync();
        await _page.GetByRole(AriaRole.Textbox, new() { Name = "Last Name" }).FillAsync("Bhattacharya");

        await _page.GetByRole(AriaRole.Textbox, new() { Name = "name@example.com" }).ClickAsync();
        await _page.GetByRole(AriaRole.Textbox, new() { Name = "name@example.com" }).FillAsync("test@gmail.com");

        await _page.GetByText("Male", new() { Exact = true }).ClickAsync();

        await _page.GetByRole(AriaRole.Textbox, new() { Name = "Mobile Number" }).ClickAsync();
        await _page.GetByRole(AriaRole.Textbox, new() { Name = "Mobile Number" }).FillAsync("8888888888");

        await _page.Locator("#dateOfBirthInput").ClickAsync();

        // Year dropdown selections
        for (int i = 0; i < 50; i++) // Simulating repeated selection of "2007"
        {
            await _page.GetByRole(AriaRole.Combobox).Nth(1).SelectOptionAsync(new[] { "2007" });
        }

        // Month dropdown selections (example value "3" = April)
        var monthSelector = _page.Locator("div")
            .Filter(new() { HasTextRegex = new Regex("^JanuaryFebruaryMarchAprilMayJuneJulyAugustSeptemberOctoberNovemberDecember$") })
            .GetByRole(AriaRole.Combobox);

        for (int i = 0; i < 20; i++)
        {
            await monthSelector.SelectOptionAsync(new[] { "3" });
        }

        // Select a specific date
        await _page.GetByRole(AriaRole.Option, new() { Name = "Choose Monday, April 9th," }).ClickAsync();

        await _page.GetByRole(AriaRole.Textbox, new() { Name = "Current Address" }).ClickAsync();
        await _page.GetByRole(AriaRole.Textbox, new() { Name = "Current Address" }).FillAsync("test");

        await _page.GetByText("Select State").ClickAsync();
        await _page.GetByText("Uttar Pradesh", new() { Exact = true }).ClickAsync();

        await _page.Locator("#city svg").ClickAsync();
        await _page.GetByText("Merrut", new() { Exact = true }).ClickAsync();

        await _page.GetByRole(AriaRole.Button, new() { Name = "Submit" }).ClickAsync();

        await _page.Locator("#fixedban div").Nth(1).ClickAsync();
        await _page.Locator("#fixedban div").Nth(1).ClickAsync();

        await _page.GetByRole(AriaRole.Button, new() { Name = "Close" }).ClickAsync();
    }
}
