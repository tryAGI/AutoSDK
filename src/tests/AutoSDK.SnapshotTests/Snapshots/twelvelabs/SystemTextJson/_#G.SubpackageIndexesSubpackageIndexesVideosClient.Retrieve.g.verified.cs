//HintName: G.SubpackageIndexesSubpackageIndexesVideosClient.Retrieve.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageIndexesSubpackageIndexesVideosClient
    {
        partial void PrepareRetrieveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexId,
            ref string videoId,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? embeddingOption,
            ref bool? transcription,
            ref string xApiKey);
        partial void PrepareRetrieveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexId,
            string videoId,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? embeddingOption,
            bool? transcription,
            string xApiKey);
        partial void ProcessRetrieveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve video information<br/>
        /// &lt;Info&gt; This method will be deprecated in a future version. New implementations should use the [Retrieve an indexed asset](/v1.3/api-reference/index-content/retrieve) method.&lt;/Info&gt;<br/>
        /// This method retrieves information about the specified video.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="videoId"></param>
        /// <param name="embeddingOption"></param>
        /// <param name="transcription"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.IndexesVideosRetrieveResponse200> RetrieveAsync(
            string indexId,
            string videoId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? embeddingOption = default,
            bool? transcription = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRetrieveArguments(
                httpClient: HttpClient,
                indexId: ref indexId,
                videoId: ref videoId,
                embeddingOption: embeddingOption,
                transcription: ref transcription,
                xApiKey: ref xApiKey);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/indexes/{indexId}/videos/{videoId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("embedding_option", embeddingOption, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                .AddOptionalParameter("transcription", transcription?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRetrieveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                indexId: indexId,
                videoId: videoId,
                embeddingOption: embeddingOption,
                transcription: transcription,
                xApiKey: xApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRetrieveResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // The request has failed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.RetrieveVideoInformationRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.RetrieveVideoInformationRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.RetrieveVideoInformationRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.RetrieveVideoInformationRequestBadRequestError>(
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
            // The specified resource does not exist.
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.RetrieveVideoInformationRequestNotFoundError? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.RetrieveVideoInformationRequestNotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.RetrieveVideoInformationRequestNotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.RetrieveVideoInformationRequestNotFoundError>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
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
                ProcessRetrieveResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.IndexesVideosRetrieveResponse200.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.IndexesVideosRetrieveResponse200.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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