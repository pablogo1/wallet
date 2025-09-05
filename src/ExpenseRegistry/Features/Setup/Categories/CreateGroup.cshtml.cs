namespace ExpenseRegistry.Features.Setup.Categories;

using MassTransit;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class CreateGroupModel : PageModel
{
    private readonly IRequestClient<CreateCategoryGroup> _requestClient;
    private readonly ILogger<CreateGroupModel> _logger;

    public CreateGroupModel(IRequestClient<CreateCategoryGroup> requestClient, ILogger<CreateGroupModel> logger)
    {
        _requestClient = requestClient;
        _logger = logger;
    }

    [BindProperty]
    public string Name { get; set; } = string.Empty;

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAddCategoryGroupAsync(CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<NewCategoryGroupViewModel>(new CreateCategoryGroup(Name), cancellationToken);
        return RedirectToPage("./Groups");
    }
}
