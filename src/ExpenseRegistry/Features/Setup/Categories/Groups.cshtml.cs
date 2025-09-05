namespace ExpenseRegistry.Features.Setup.Categories;

using MassTransit;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class GroupsModel : PageModel
{
    private readonly IRequestClient<CreateCategoryGroup> _requestClient;
    private readonly ILogger<GroupsModel> _logger;

    public GroupsModel(IRequestClient<CreateCategoryGroup> requestClient, ILogger<GroupsModel> logger)
    {
        _logger = logger;
        _requestClient = requestClient;
    }

    [BindProperty]
    public NewCategoryGroupViewModel NewGroup { get; set; } = new();

    
}