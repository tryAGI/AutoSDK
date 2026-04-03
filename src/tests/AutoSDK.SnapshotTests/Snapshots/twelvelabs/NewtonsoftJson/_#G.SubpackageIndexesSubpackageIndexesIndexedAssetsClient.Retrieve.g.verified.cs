//HintName: G.SubpackageIndexesSubpackageIndexesIndexedAssetsClient.Retrieve.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        partial void PrepareRetrieveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexId,
            ref string indexedAssetId,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? embeddingOption,
            ref bool? transcription,
            ref string xApiKey);
        partial void PrepareRetrieveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexId,
            string indexedAssetId,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? embeddingOption,
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
        /// Retrieve indexed asset information<br/>
        /// This method retrieves information about an indexed asset, including its status, metadata, and optional embeddings or transcription.<br/>
        /// Use this method to:<br/>
        /// - Monitor the indexing progress:<br/>
        ///     - Call this endpoint after creating an indexed asset<br/>
        ///     - Check the `status` field until it shows `ready`<br/>
        ///     - Once ready, your content is available for search and analysis<br/>
        /// - Retrieve the asset metadata:<br/>
        ///     - Retrieve system metadata (duration, resolution, filename)<br/>
        ///     - Access user-defined metadata<br/>
        /// - Retrieve the embeddings:<br/>
        ///     - Include the `embeddingOption` parameter to retrieve video embeddings<br/>
        ///     - Requires the Marengo video understanding model to be enabled in your index<br/>
        /// - Retrieve transcriptions:<br/>
        ///   - Set the `transcription` parameter to `true` to retrieve spoken words from your video
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="indexedAssetId"></param>
        /// <param name="embeddingOption"></param>
        /// <param name="transcription"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.IndexedAssetDetailed> RetrieveAsync(
            string indexId,
            string indexedAssetId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? embeddingOption = default,
            bool? transcription = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRetrieveArguments(
                httpClient: HttpClient,
                indexId: ref indexId,
                indexedAssetId: ref indexedAssetId,
                embeddingOption: embeddingOption,
                transcription: ref transcription,
                xApiKey: ref xApiKey);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/indexes/{indexId}/indexed-assets/{indexedAssetId}",
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
                indexedAssetId: indexedAssetId,
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
                global::G.RetrieveIndexedAssetInformationRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.RetrieveIndexedAssetInformationRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.RetrieveIndexedAssetInformationRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.RetrieveIndexedAssetInformationRequestBadRequestError>(
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
                global::G.RetrieveIndexedAssetInformationRequestNotFoundError? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.RetrieveIndexedAssetInformationRequestNotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.RetrieveIndexedAssetInformationRequestNotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.RetrieveIndexedAssetInformationRequestNotFoundError>(
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
                        global::G.IndexedAssetDetailed.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.IndexedAssetDetailed.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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