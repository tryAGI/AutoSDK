//HintName: G.ReactionsClient.CreateReactions.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareCreateReactionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.CreateReactionsCategory category,
            ref int reactableId,
            ref global::G.CreateReactionsReactableType reactableType);
        partial void PrepareCreateReactionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateReactionsCategory category,
            int reactableId,
            global::G.CreateReactionsReactableType reactableType);
        partial void ProcessCreateReactionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// create reaction<br/>
        /// This endpoint allows the client to create a reaction to a specified reactable (eg, Article, Comment, or User). For examples:<br/>
        ///         * "Like"ing an Article will create a new "like" Reaction from the user for that Articles<br/>
        ///         * "Like"ing that Article a second time will return the previous "like"
        /// </summary>
        /// <param name="category"></param>
        /// <param name="reactableId"></param>
        /// <param name="reactableType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateReactionsAsync(
            global::G.CreateReactionsCategory category,
            int reactableId,
            global::G.CreateReactionsReactableType reactableType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateReactionsArguments(
                httpClient: HttpClient,
                category: ref category,
                reactableId: ref reactableId,
                reactableType: ref reactableType);

            var categoryValue = category switch
            {
                global::G.CreateReactionsCategory.Like => "like",
                global::G.CreateReactionsCategory.Unicorn => "unicorn",
                global::G.CreateReactionsCategory.ExplodingHead => "exploding_head",
                global::G.CreateReactionsCategory.RaisedHands => "raised_hands",
                global::G.CreateReactionsCategory.Fire => "fire",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var reactableTypeValue = reactableType switch
            {
                global::G.CreateReactionsReactableType.Comment => "Comment",
                global::G.CreateReactionsReactableType.Article => "Article",
                global::G.CreateReactionsReactableType.User => "User",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/reactions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("category", category.ToValueString())
                .AddRequiredParameter("reactable_id", reactableId.ToString()!)
                .AddRequiredParameter("reactable_type", reactableType.ToValueString()) 
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateReactionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                category: category,
                reactableId: reactableId,
                reactableType: reactableType);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateReactionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
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
    }
}