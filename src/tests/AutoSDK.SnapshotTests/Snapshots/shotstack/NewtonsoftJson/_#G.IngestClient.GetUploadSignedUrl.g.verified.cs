//HintName: G.IngestClient.GetUploadSignedUrl.g.cs

#nullable enable

namespace G
{
    public partial class IngestClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetUploadSignedUrlSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "",
                        Location = "",
                        Name = "",
                        FriendlyName = "Authorization",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_GetUploadSignedUrlSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetUploadSignedUrlSecurityRequirement0,
            };
        partial void PrepareGetUploadSignedUrlArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareGetUploadSignedUrlRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessGetUploadSignedUrlResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetUploadSignedUrlResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Direct Upload<br/>
        /// Request a signed URL to upload a file to. The response returns a signed URL that you use to upload the file to.<br/>
        /// The signed URL looks similar to:<br/>
        /// https://shotstack-ingest-api-stage-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/source?AWSAccessKeyId=ASIAWJV7UWDMGTZLHTXP&amp;Expires=1677209777&amp;Signature=PKR4dGDDdOuMTAQmDASzLGmLOeo%3D&amp;x-amz-acl=public-read&amp;x-amz-security-token=IQoJb3JpZ2luX2VjEGMaDmFwLX......56osBGByztm7WZdbmXzO09KR<br/>
        /// In a separate API call, use this signed URL to send a PUT request with the binary file. Using  cURL you can use<br/>
        /// a command like:<br/>
        ///     <br/>
        /// `curl -X PUT -T video.mp4 {data.attributes.url}`<br/>
        ///     <br/>
        /// Where **video.mp4** is the file you want to upload and **{data.attributes.url}** is the signed URL returned in<br/>
        /// the response. The request must be a PUT type.<br/>
        /// The SDK does not currently support the PUT request. You can use the SDK to make the request for the signed URL<br/>
        /// and then use cURL to make the PUT request.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/ingest/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UploadResponse> GetUploadSignedUrlAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetUploadSignedUrlArguments(
                httpClient: HttpClient);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetUploadSignedUrlSecurityRequirements,
                operationName: "GetUploadSignedUrlAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/ingest/v1/upload",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetUploadSignedUrlRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetUploadSignedUrlResponse(
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
                ProcessGetUploadSignedUrlResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.UploadResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.UploadResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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