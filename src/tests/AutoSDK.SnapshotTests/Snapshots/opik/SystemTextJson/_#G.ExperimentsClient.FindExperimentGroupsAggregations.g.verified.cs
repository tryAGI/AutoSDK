//HintName: G.ExperimentsClient.FindExperimentGroupsAggregations.g.cs

#nullable enable

namespace G
{
    public partial class ExperimentsClient
    {
        partial void PrepareFindExperimentGroupsAggregationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? groups,
            ref string? types,
            ref string? name,
            ref global::System.Guid? projectId,
            ref bool? projectDeleted,
            ref string? filters);
        partial void PrepareFindExperimentGroupsAggregationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? groups,
            string? types,
            string? name,
            global::System.Guid? projectId,
            bool? projectDeleted,
            string? filters);
        partial void ProcessFindExperimentGroupsAggregationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFindExperimentGroupsAggregationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Find experiment groups with aggregations<br/>
        /// Find experiments grouped by specified fields with aggregation metrics
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="types"></param>
        /// <param name="name">
        /// Filter experiments by name (partial match, case insensitive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="projectDeleted">
        /// Filter experiments by deleted projects
        /// </param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExperimentGroupAggregationsResponse> FindExperimentGroupsAggregationsAsync(
            string? groups = default,
            string? types = default,
            string? name = default,
            global::System.Guid? projectId = default,
            bool? projectDeleted = default,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFindExperimentGroupsAggregationsArguments(
                httpClient: HttpClient,
                groups: ref groups,
                types: ref types,
                name: ref name,
                projectId: ref projectId,
                projectDeleted: ref projectDeleted,
                filters: ref filters);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/experiments/groups/aggregations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("groups", groups)
                .AddOptionalParameter("types", types)
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("project_deleted", projectDeleted?.ToString().ToLowerInvariant())
                .AddOptionalParameter("filters", filters) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFindExperimentGroupsAggregationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                groups: groups,
                types: types,
                name: name,
                projectId: projectId,
                projectDeleted: projectDeleted,
                filters: filters);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFindExperimentGroupsAggregationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.ErrorMessage? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.ErrorMessage.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.ErrorMessage.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorMessage>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
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
                ProcessFindExperimentGroupsAggregationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ExperimentGroupAggregationsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ExperimentGroupAggregationsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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