namespace ExpenseRegistry.Tests.Features.Setup.Categories;

using ExpenseRegistry.Features.Setup.Categories;

using FluentAssertions;

using MassTransit;
using MassTransit.Mediator;
using MassTransit.Testing;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Moq;

public class GroupsModelTests : IAsyncDisposable
{
    readonly ServiceProvider _serviceProvider;
    readonly ITestHarness _harness;

    public GroupsModelTests()
    {
        Mock<ILogger<GroupsModel>> loggerMock = new();
        ServiceCollection services = new();
        services.AddSingleton(loggerMock.Object);
        services.AddSingleton<GroupsModel>();
        services.AddMassTransitTestHarness(x =>
        {
            x.AddMediator(cfg =>
            {
                cfg.AddConsumer<CreateCategoryGroupCommandConsumer>();
            });
        });

        _serviceProvider = services.BuildServiceProvider(true);

        _harness = _serviceProvider.GetTestHarness();
    }

    public async ValueTask DisposeAsync()
    {
        await _serviceProvider.DisposeAsync();
    }

    [Fact]
    public async Task Should_send_CreateCategoryGroupCommand_when_clicking_submit()
    {
        // Given
        await _harness.Start();

        var sut = _serviceProvider.GetRequiredService<GroupsModel>();

        sut.NewGroup.Name = "Test";

        // When
        _ = await sut.OnPostAddCategoryGroupAsync(CancellationToken.None);

        // Then
        //mediatorMock.Verify(
        //    m => m.Send(It.Is<CreateCategoryGroupCommand>(x => x.Name == sut.NewGroup.Name), It.IsAny<CancellationToken>()),
        //    Times.Once);
        bool sent = await _harness.Sent.Any<CreateCategoryGroup>();
        sent.Should().Be(true);
    }

    [Fact]
    public async Task Should_return_to_same_page_when_CreateCategoryGroupCommand_is_successful()
    {
        // Given
        await _harness.Start();

        var sut = _serviceProvider.GetRequiredService<GroupsModel>();

        sut.NewGroup.Name = "Test";

        // When
        var result = await sut.OnPostAddCategoryGroupAsync(CancellationToken.None);

        // Then
        result.Should().BeOfType<PageResult>();

        //var pageResult = result as PageResult;
        //pageResult?.Model.Should().NotBeNull();
    }
}