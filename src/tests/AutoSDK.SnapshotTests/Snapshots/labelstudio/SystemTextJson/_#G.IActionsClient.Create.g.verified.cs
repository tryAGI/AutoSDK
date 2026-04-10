//HintName: G.IActionsClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Post actions<br/>
        /// Perform a Data Manager action with the selected tasks and filters. Note: More complex actions require additional parameters in the request body. Call `GET api/actions?project=&lt;id&gt;` to explore them. Example: `GET api/actions?id=delete_tasks&amp;project=1`
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAsync(
            global::G.ApiDmActionsCreateId id,
            int project,

            global::G.ApiDmActionsCreateRequest request,
            int? view = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post actions<br/>
        /// Perform a Data Manager action with the selected tasks and filters. Note: More complex actions require additional parameters in the request body. Call `GET api/actions?project=&lt;id&gt;` to explore them. Example: `GET api/actions?id=delete_tasks&amp;project=1`
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="filters">
        /// Filters to apply on tasks. You can use [the helper class `Filters` from this page](https://labelstud.io/sdk/data_manager.html) to create Data Manager Filters.Example: `{"conjunction": "or", "items": [{"filter": "filter:tasks:completed_at", "operator": "greater", "type": "Datetime", "value": "2021-01-01T00:00:00.000Z"}]}`
        /// </param>
        /// <param name="ordering">
        /// List of fields to order by. Fields are similar to filters but without the `filter:` prefix. To reverse the order, add a minus sign before the field name, e.g. `-tasks:created_at`.
        /// </param>
        /// <param name="selectedItems">
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAsync(
            global::G.ApiDmActionsCreateId id,
            int project,
            int? view = default,
            global::G.ApiDmActionsCreateRequestFilters? filters = default,
            global::System.Collections.Generic.IList<global::G.ApiDmActionsCreateRequestOrderingItem>? ordering = default,
            global::G.OneOf<global::G.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::G.ApiDmActionsCreateRequestSelectedItemsAllTrue>? selectedItems = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}