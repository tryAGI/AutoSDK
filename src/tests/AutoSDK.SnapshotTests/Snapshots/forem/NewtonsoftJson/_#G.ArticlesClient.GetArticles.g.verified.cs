//HintName: G.ArticlesClient.GetArticles.g.cs

#nullable enable

namespace G
{
    public partial class ArticlesClient
    {
        partial void PrepareGetArticlesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? perPage,
            ref string? tag,
            ref string? tags,
            ref string? tagsExclude,
            ref string? username,
            ref global::G.GetArticlesState? state,
            ref int? top,
            ref int? collectionId);
        partial void PrepareGetArticlesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? perPage,
            string? tag,
            string? tags,
            string? tagsExclude,
            string? username,
            global::G.GetArticlesState? state,
            int? top,
            int? collectionId);
        partial void ProcessGetArticlesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetArticlesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Published articles<br/>
        /// This endpoint allows the client to retrieve a list of articles.<br/>
        /// "Articles" are all the posts that users create on DEV that typically<br/>
        /// show up in the feed. They can be a blog post, a discussion question,<br/>
        /// a help thread etc. but is referred to as article within the code.<br/>
        /// By default it will return featured, published articles ordered<br/>
        /// by descending popularity.<br/>
        /// It supports pagination, each page will contain `30` articles by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="tag"></param>
        /// <param name="tags"></param>
        /// <param name="tagsExclude"></param>
        /// <param name="username"></param>
        /// <param name="state"></param>
        /// <param name="top"></param>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ArticleIndex>> GetArticlesAsync(
            int? page = default,
            int? perPage = default,
            string? tag = default,
            string? tags = default,
            string? tagsExclude = default,
            string? username = default,
            global::G.GetArticlesState? state = default,
            int? top = default,
            int? collectionId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetArticlesArguments(
                httpClient: HttpClient,
                page: ref page,
                perPage: ref perPage,
                tag: ref tag,
                tags: ref tags,
                tagsExclude: ref tagsExclude,
                username: ref username,
                state: ref state,
                top: ref top,
                collectionId: ref collectionId);

            var stateValue = state switch
            {
                global::G.GetArticlesState.Fresh => "fresh",
                global::G.GetArticlesState.Rising => "rising",
                global::G.GetArticlesState.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/articles",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("per_page", perPage?.ToString())
                .AddOptionalParameter("tag", tag)
                .AddOptionalParameter("tags", tags)
                .AddOptionalParameter("tags_exclude", tagsExclude)
                .AddOptionalParameter("username", username)
                .AddOptionalParameter("state", state?.ToValueString())
                .AddOptionalParameter("top", top?.ToString())
                .AddOptionalParameter("collection_id", collectionId?.ToString()) 
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
            PrepareGetArticlesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                page: page,
                perPage: perPage,
                tag: tag,
                tags: tags,
                tagsExclude: tagsExclude,
                username: username,
                state: state,
                top: top,
                collectionId: collectionId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetArticlesResponse(
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
                ProcessGetArticlesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.ArticleIndex>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.ArticleIndex>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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