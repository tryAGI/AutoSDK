//HintName: G.ActionsClient.Create.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.ApiDmActionsCreateId id,
            ref int project,
            ref int? view,
            global::G.ApiDmActionsCreateRequest request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ApiDmActionsCreateId id,
            int project,
            int? view,
            global::G.ApiDmActionsCreateRequest request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Post actions<br/>
        /// Perform a Data Manager action with the selected tasks and filters. Note: More complex actions require additional parameters in the request body. Call `GET api/actions?project=&lt;id&gt;` to explore them. Example: `GET api/actions?id=delete_tasks&amp;project=1`
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateAsync(
            global::G.ApiDmActionsCreateId id,
            int project,

            global::G.ApiDmActionsCreateRequest request,
            int? view = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                id: ref id,
                project: ref project,
                view: ref view,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/dm/actions/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("id", id.ToValueString())
                .AddRequiredParameter("project", project.ToString()!)
                .AddOptionalParameter("view", view?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                project: project,
                view: view,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateAsync(
            global::G.ApiDmActionsCreateId id,
            int project,
            int? view = default,
            global::G.ApiDmActionsCreateRequestFilters? filters = default,
            global::System.Collections.Generic.IList<global::G.ApiDmActionsCreateRequestOrderingItem>? ordering = default,
            global::G.OneOf<global::G.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::G.ApiDmActionsCreateRequestSelectedItemsAllTrue>? selectedItems = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ApiDmActionsCreateRequest
            {
                Filters = filters,
                Ordering = ordering,
                SelectedItems = selectedItems,
            };

            await CreateAsync(
                id: id,
                project: project,
                view: view,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}