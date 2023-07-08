namespace ExpenseRegistry.Features.Setup.Categories;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class GroupsModel : PageModel
{
    readonly ILogger<GroupsModel> _logger;

    public GroupsModel(ILogger<GroupsModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public NewCategoryGroupViewModel NewGroup { get; set; } = new();

    public async Task<IActionResult> OnPostAddMessageAsync()
    {
        await Task.Delay(50);
        _logger.LogInformation("test");
        return RedirectToPage();
    }
}