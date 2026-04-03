//HintName: G.FileApiClient.GatewayDownloadFile.g.cs

#nullable enable

namespace G
{
    public partial class FileApiClient
    {
        partial void PrepareGatewayDownloadFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string fileId);
        partial void PrepareGatewayDownloadFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string fileId);
        partial void ProcessGatewayDownloadFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGatewayDownloadFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Download file<br/>
        /// Download the binary content of a file. The response will contain the file data in the appropriate MIME type.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/files/{file_id}/download \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<byte[]> GatewayDownloadFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GatewayDownloadFileAsResponseAsync(
                fileId: fileId,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Download file<br/>
        /// Download the binary content of a file. The response will contain the file data in the appropriate MIME type.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/files/{file_id}/download \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> GatewayDownloadFileAsResponseAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGatewayDownloadFileArguments(
                httpClient: HttpClient,
                fileId: ref fileId);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/files/{fileId}/download",
                baseUri: HttpClient.BaseAddress); 
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
            PrepareGatewayDownloadFileRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fileId: fileId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGatewayDownloadFileResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessGatewayDownloadFileResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return new global::G.AutoSDKHttpResponse<byte[]>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
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
                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return new global::G.AutoSDKHttpResponse<byte[]>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
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