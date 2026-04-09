//HintName: G.SubpackageIndexesSubpackageIndexesIndexedAssetsClient.List.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        partial void PrepareListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexId,
            ref int? page,
            ref int? pageLimit,
            ref string? sortBy,
            ref string? sortOption,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? status,
            ref string? filename,
            ref double? duration,
            ref double? fps,
            ref double? width,
            ref int? height,
            ref double? size,
            ref string? createdAt,
            ref string? updatedAt,
            object? userMetadata,
            ref string xApiKey);
        partial void PrepareListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexId,
            int? page,
            int? pageLimit,
            string? sortBy,
            string? sortOption,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? status,
            string? filename,
            double? duration,
            double? fps,
            double? width,
            int? height,
            double? size,
            string? createdAt,
            string? updatedAt,
            object? userMetadata,
            string xApiKey);
        partial void ProcessListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List indexed assets<br/>
        /// This method returns a list of the indexed assets in the specified index. By default, the platform returns your indexed assets sorted by creation date, with the newest at the top of the list.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="status"></param>
        /// <param name="filename"></param>
        /// <param name="duration"></param>
        /// <param name="fps"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="size"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userMetadata"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.IndexesIndexedAssetsListResponse200> ListAsync(
            string indexId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            string? sortBy = default,
            string? sortOption = default,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? status = default,
            string? filename = default,
            double? duration = default,
            double? fps = default,
            double? width = default,
            int? height = default,
            double? size = default,
            string? createdAt = default,
            string? updatedAt = default,
            object? userMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListArguments(
                httpClient: HttpClient,
                indexId: ref indexId,
                page: ref page,
                pageLimit: ref pageLimit,
                sortBy: ref sortBy,
                sortOption: ref sortOption,
                status: status,
                filename: ref filename,
                duration: ref duration,
                fps: ref fps,
                width: ref width,
                height: ref height,
                size: ref size,
                createdAt: ref createdAt,
                updatedAt: ref updatedAt,
                userMetadata: userMetadata,
                xApiKey: ref xApiKey);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/indexes/{indexId}/indexed-assets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_limit", pageLimit?.ToString())
                .AddOptionalParameter("sort_by", sortBy)
                .AddOptionalParameter("sort_option", sortOption)
                .AddOptionalParameter("status", status, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                .AddOptionalParameter("filename", filename)
                .AddOptionalParameter("duration", duration?.ToString())
                .AddOptionalParameter("fps", fps?.ToString())
                .AddOptionalParameter("width", width?.ToString())
                .AddOptionalParameter("height", height?.ToString())
                .AddOptionalParameter("size", size?.ToString())
                .AddOptionalParameter("created_at", createdAt)
                .AddOptionalParameter("updated_at", updatedAt)
                .AddOptionalParameter("user_metadata", userMetadata?.ToString()) 
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
            PrepareListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                indexId: indexId,
                page: page,
                pageLimit: pageLimit,
                sortBy: sortBy,
                sortOption: sortOption,
                status: status,
                filename: filename,
                duration: duration,
                fps: fps,
                width: width,
                height: height,
                size: size,
                createdAt: createdAt,
                updatedAt: updatedAt,
                userMetadata: userMetadata,
                xApiKey: xApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // The request has failed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.ListIndexedAssetsRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.ListIndexedAssetsRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.ListIndexedAssetsRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.ListIndexedAssetsRequestBadRequestError>(
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
                ProcessListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.IndexesIndexedAssetsListResponse200.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.IndexesIndexedAssetsListResponse200.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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