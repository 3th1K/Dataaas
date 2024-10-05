using Dataaas.Web.Models;
using Microsoft.AspNetCore.Components;

namespace Dataaas.Web.Components.SharedComponents;

public sealed partial class _ApiCardsWithPagination
{
    [Parameter]
    public List<ApiSummary> Apis { get; set; } = [];

    [Parameter]
    public EventCallback<ApiSummary> OnClick { get; set; }

    private readonly int PageSize = 9; // Number of cards per page
    private int CurrentPage = 1;

    private IEnumerable<ApiSummary> PagedApis => Apis
        .Skip((CurrentPage - 1) * PageSize)
    .Take(PageSize);

    private int TotalPages => (int)Math.Ceiling(Apis.Count / (double)PageSize);

    private bool IsFirstPage => CurrentPage == 1;
    private bool IsLastPage => CurrentPage == TotalPages;

    private void PreviousPage()
    {
        if (!IsFirstPage)
        {
            CurrentPage--;
        }
    }

    private void NextPage()
    {
        if (!IsLastPage)
        {
            CurrentPage++;
        }
    }

    public void ApiOnClick(ApiSummary api)
    {
        OnClick.InvokeAsync(api);
    }
}