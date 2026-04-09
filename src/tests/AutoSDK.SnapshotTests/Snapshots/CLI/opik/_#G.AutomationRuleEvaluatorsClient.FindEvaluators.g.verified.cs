//HintName: G.AutomationRuleEvaluatorsClient.FindEvaluators.g.cs

#nullable enable

namespace G
{
    public partial class AutomationRuleEvaluatorsClient
    {
        partial void PrepareFindEvaluatorsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid? projectId,
            ref string? id,
            ref string? name,
            ref string? filters,
            ref string? sorting,
            ref int? page,
            ref int? size);
        partial void PrepareFindEvaluatorsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? projectId,
            string? id,
            string? name,
            string? filters,
            string? sorting,
            int? page,
            int? size);
        partial void ProcessFindEvaluatorsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFindEvaluatorsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Find project Evaluators<br/>
        /// Find project Evaluators
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id">
        /// Filter automation rules with rule ID containing this value (partial match, like %id%)
        /// </param>
        /// <param name="name">
        /// Filter automation rule evaluators by name (partial match, case insensitive)
        /// </param>
        /// <param name="filters"></param>
        /// <param name="sorting"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutomationRuleEvaluatorPagePublic> FindEvaluatorsAsync(
            global::System.Guid? projectId = default,
            string? id = default,
            string? name = default,
            string? filters = default,
            string? sorting = default,
            int? page = default,
            int? size = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFindEvaluatorsArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                id: ref id,
                name: ref name,
                filters: ref filters,
                sorting: ref sorting,
                page: ref page,
                size: ref size);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/automations/evaluators",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("id", id)
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("filters", filters)
                .AddOptionalParameter("sorting", sorting)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("size", size?.ToString()) 
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
            PrepareFindEvaluatorsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                id: id,
                name: name,
                filters: filters,
                sorting: sorting,
                page: page,
                size: size);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFindEvaluatorsResponse(
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
                ProcessFindEvaluatorsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AutomationRuleEvaluatorPagePublic.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.AutomationRuleEvaluatorPagePublic.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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