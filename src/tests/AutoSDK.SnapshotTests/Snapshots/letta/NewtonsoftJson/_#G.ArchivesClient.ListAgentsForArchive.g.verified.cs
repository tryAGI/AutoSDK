//HintName: G.ArchivesClient.ListAgentsForArchive.g.cs

#nullable enable

namespace G
{
    public partial class ArchivesClient
    {
        partial void PrepareListAgentsForArchiveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string archiveId,
            ref string? before,
            ref string? after,
            int? limit,
            ref global::G.ListAgentsForArchiveOrder? order,
            global::System.Collections.Generic.IList<global::G.ListAgentsForArchiveIncludeItem>? include);
        partial void PrepareListAgentsForArchiveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string archiveId,
            string? before,
            string? after,
            int? limit,
            global::G.ListAgentsForArchiveOrder? order,
            global::System.Collections.Generic.IList<global::G.ListAgentsForArchiveIncludeItem>? include);
        partial void ProcessListAgentsForArchiveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListAgentsForArchiveResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Agents For Archive<br/>
        /// Get a list of agents that have access to an archive with pagination support.
        /// </summary>
        /// <param name="archiveId">
        /// The ID of the archive in the format 'archive-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// Agent ID cursor for pagination. Returns agents that come before this agent ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Agent ID cursor for pagination. Returns agents that come after this agent ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of agents to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for agents by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="include">
        /// Specify which relational fields to include in the response. No relationships are included by default.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AgentState>> ListAgentsForArchiveAsync(
            string archiveId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListAgentsForArchiveOrder? order = default,
            global::System.Collections.Generic.IList<global::G.ListAgentsForArchiveIncludeItem>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListAgentsForArchiveArguments(
                httpClient: HttpClient,
                archiveId: ref archiveId,
                before: ref before,
                after: ref after,
                limit: limit,
                order: ref order,
                include: include);

            var orderValue = order switch
            {
                global::G.ListAgentsForArchiveOrder.Asc => "asc",
                global::G.ListAgentsForArchiveOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/archives/{archiveId}/agents",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("before", before)
                .AddOptionalParameter("after", after)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("include", include, selector: static x => x.ToValueString(), delimiter: ",", explode: true) 
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
            PrepareListAgentsForArchiveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                archiveId: archiveId,
                before: before,
                after: after,
                limit: limit,
                order: order,
                include: include);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListAgentsForArchiveResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessListAgentsForArchiveResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.AgentState>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.AgentState>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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