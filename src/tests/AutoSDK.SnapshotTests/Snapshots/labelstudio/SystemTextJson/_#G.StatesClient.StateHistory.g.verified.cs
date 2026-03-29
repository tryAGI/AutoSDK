//HintName: G.StatesClient.StateHistory.g.cs

#nullable enable

namespace G
{
    public partial class StatesClient
    {
        partial void PrepareStateHistoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? createdAtFrom,
            ref string? createdAtTo,
            ref int entityId,
            ref string entityName,
            ref string? ordering,
            ref int? page,
            ref int? pageSize,
            ref string? previousState,
            ref string? state,
            ref string? transitionName,
            ref double? triggeredBy);
        partial void PrepareStateHistoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? createdAtFrom,
            string? createdAtTo,
            int entityId,
            string entityName,
            string? ordering,
            int? page,
            int? pageSize,
            string? previousState,
            string? state,
            string? transitionName,
            double? triggeredBy);
        partial void ProcessStateHistoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStateHistoryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ✨ Get entity state history<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Get the state history of an entity
        /// </summary>
        /// <param name="createdAtFrom"></param>
        /// <param name="createdAtTo"></param>
        /// <param name="entityId"></param>
        /// <param name="entityName"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="previousState"></param>
        /// <param name="state"></param>
        /// <param name="transitionName"></param>
        /// <param name="triggeredBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedStateModelList> StateHistoryAsync(
            int entityId,
            string entityName,
            string? createdAtFrom = default,
            string? createdAtTo = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? previousState = default,
            string? state = default,
            string? transitionName = default,
            double? triggeredBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareStateHistoryArguments(
                httpClient: HttpClient,
                createdAtFrom: ref createdAtFrom,
                createdAtTo: ref createdAtTo,
                entityId: ref entityId,
                entityName: ref entityName,
                ordering: ref ordering,
                page: ref page,
                pageSize: ref pageSize,
                previousState: ref previousState,
                state: ref state,
                transitionName: ref transitionName,
                triggeredBy: ref triggeredBy);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/fsm/entities/{entityName}/{entityId}/history",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("created_at_from", createdAtFrom)
                .AddOptionalParameter("created_at_to", createdAtTo)
                .AddOptionalParameter("ordering", ordering)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("previous_state", previousState)
                .AddOptionalParameter("state", state)
                .AddOptionalParameter("transition_name", transitionName)
                .AddOptionalParameter("triggered_by", triggeredBy?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareStateHistoryRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                createdAtFrom: createdAtFrom,
                createdAtTo: createdAtTo,
                entityId: entityId,
                entityName: entityName,
                ordering: ordering,
                page: page,
                pageSize: pageSize,
                previousState: previousState,
                state: state,
                transitionName: transitionName,
                triggeredBy: triggeredBy);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessStateHistoryResponse(
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
                ProcessStateHistoryResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PaginatedStateModelList.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.PaginatedStateModelList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
    }
}