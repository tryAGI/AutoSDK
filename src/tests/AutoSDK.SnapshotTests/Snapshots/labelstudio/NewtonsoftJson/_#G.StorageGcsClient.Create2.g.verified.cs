//HintName: G.StorageGcsClient.Create2.g.cs

#nullable enable

namespace G
{
    public partial class StorageGcsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_Create2SecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_Create2SecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_Create2SecurityRequirement0,
            };
        partial void PrepareCreate2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ApiStoragesGcsCreateRequest request);
        partial void PrepareCreate2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ApiStoragesGcsCreateRequest request);
        partial void ProcessCreate2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreate2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create import storage<br/>
        /// Create a new GCS import storage connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GCSImportStorage> Create2Async(

            global::G.ApiStoragesGcsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreate2Arguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_Create2SecurityRequirements,
                operationName: "Create2Async");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/storages/gcs/",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreate2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreate2Response(
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
                ProcessCreate2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GCSImportStorage.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GCSImportStorage.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// Create import storage<br/>
        /// Create a new GCS import storage connection.
        /// </summary>
        /// <param name="bucket">
        /// GCS bucket name
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="googleApplicationCredentials">
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file. Check official Google Cloud Authentication documentation for more details.
        /// </param>
        /// <param name="googleProjectId">
        /// Google project ID
        /// </param>
        /// <param name="prefix">
        /// GCS bucket prefix
        /// </param>
        /// <param name="presign">
        /// Presign URLs for direct download<br/>
        /// Default Value: true
        /// </param>
        /// <param name="presignTtl">
        /// Presign TTL in minutes<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects. You must specify it otherwise no objects will be imported.
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs. For example, if your bucket contains images, you can use this option to generate URLs for these images. If set to False, it will read the content of the file and load it into Label Studio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GCSImportStorage> Create2Async(
            string? bucket = default,
            string? description = default,
            string? googleApplicationCredentials = default,
            string? googleProjectId = default,
            string? prefix = default,
            bool? presign = default,
            int? presignTtl = default,
            int? project = default,
            string? regexFilter = default,
            string? title = default,
            bool? useBlobUrls = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ApiStoragesGcsCreateRequest
            {
                Bucket = bucket,
                Description = description,
                GoogleApplicationCredentials = googleApplicationCredentials,
                GoogleProjectId = googleProjectId,
                Prefix = prefix,
                Presign = presign,
                PresignTtl = presignTtl,
                Project = project,
                RegexFilter = regexFilter,
                Title = title,
                UseBlobUrls = useBlobUrls,
            };

            return await Create2Async(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}