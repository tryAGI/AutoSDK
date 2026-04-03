//HintName: G.TemplatesClient.TemplatesListTemplates.g.cs

#nullable enable

namespace G
{
    public partial class TemplatesClient
    {
        partial void PrepareTemplatesListTemplatesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.OneOf<string, double?>? offset,
            ref string? exact,
            ref string? limit,
            ref string? version,
            ref string? templateId,
            ref string? name,
            ref string? search,
            ref string? projectSlug,
            ref string? projectId,
            ref global::G.TemplatesListTemplatesSortBy? sortBy);
        partial void PrepareTemplatesListTemplatesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OneOf<string, double?>? offset,
            string? exact,
            string? limit,
            string? version,
            string? templateId,
            string? name,
            string? search,
            string? projectSlug,
            string? projectId,
            global::G.TemplatesListTemplatesSortBy? sortBy);
        partial void ProcessTemplatesListTemplatesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTemplatesListTemplatesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List templates (Cloud-only)<br/>
        /// List all templates
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="exact"></param>
        /// <param name="limit"></param>
        /// <param name="version"></param>
        /// <param name="templateId"></param>
        /// <param name="name"></param>
        /// <param name="search"></param>
        /// <param name="projectSlug"></param>
        /// <param name="projectId"></param>
        /// <param name="sortBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TemplatesListTemplatesResponse> TemplatesListTemplatesAsync(
            global::G.OneOf<string, double?>? offset = default,
            string? exact = default,
            string? limit = default,
            string? version = default,
            string? templateId = default,
            string? name = default,
            string? search = default,
            string? projectSlug = default,
            string? projectId = default,
            global::G.TemplatesListTemplatesSortBy? sortBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTemplatesListTemplatesArguments(
                httpClient: HttpClient,
                offset: ref offset,
                exact: ref exact,
                limit: ref limit,
                version: ref version,
                templateId: ref templateId,
                name: ref name,
                search: ref search,
                projectSlug: ref projectSlug,
                projectId: ref projectId,
                sortBy: ref sortBy);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/templates",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("exact", exact)
                .AddOptionalParameter("limit", limit)
                .AddOptionalParameter("version", version)
                .AddOptionalParameter("template_id", templateId)
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("project_slug", projectSlug)
                .AddOptionalParameter("project_id", projectId)
                .AddOptionalParameter("sort_by", sortBy?.ToValueString()) 
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
            PrepareTemplatesListTemplatesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                offset: offset,
                exact: exact,
                limit: limit,
                version: version,
                templateId: templateId,
                name: name,
                search: search,
                projectSlug: projectSlug,
                projectId: projectId,
                sortBy: sortBy);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTemplatesListTemplatesResponse(
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
                ProcessTemplatesListTemplatesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TemplatesListTemplatesResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TemplatesListTemplatesResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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