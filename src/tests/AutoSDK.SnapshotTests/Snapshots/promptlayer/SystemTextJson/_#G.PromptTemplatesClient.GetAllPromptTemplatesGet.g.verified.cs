//HintName: G.PromptTemplatesClient.GetAllPromptTemplatesGet.g.cs

#nullable enable

namespace G
{
    public partial class PromptTemplatesClient
    {
        partial void PrepareGetAllPromptTemplatesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? perPage,
            ref string? label,
            ref string? name,
            ref global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags,
            ref global::G.GetAllPromptTemplatesGetStatus? status);
        partial void PrepareGetAllPromptTemplatesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? perPage,
            string? label,
            string? name,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags,
            global::G.GetAllPromptTemplatesGetStatus? status);
        partial void ProcessGetAllPromptTemplatesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAllPromptTemplatesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="label"></param>
        /// <param name="name"></param>
        /// <param name="tags"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListPromptTemplates> GetAllPromptTemplatesGetAsync(
            int? page = default,
            int? perPage = default,
            string? label = default,
            string? name = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            global::G.GetAllPromptTemplatesGetStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAllPromptTemplatesGetArguments(
                httpClient: HttpClient,
                page: ref page,
                perPage: ref perPage,
                label: ref label,
                name: ref name,
                tags: ref tags,
                status: ref status);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/prompt-templates",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("per_page", perPage?.ToString())
                .AddOptionalParameter("label", label)
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("tags", tags?.ToString())
                .AddOptionalParameter("status", status?.ToValueString()) 
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
            PrepareGetAllPromptTemplatesGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                page: page,
                perPage: perPage,
                label: label,
                name: name,
                tags: tags,
                status: status);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAllPromptTemplatesGetResponse(
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
                ProcessGetAllPromptTemplatesGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ListPromptTemplates.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ListPromptTemplates.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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