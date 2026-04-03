//HintName: G.StorageS3RolesClient.Update2.g.cs

#nullable enable

namespace G
{
    public partial class StorageS3RolesClient
    {
        partial void PrepareUpdate2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            global::G.PatchedLseS3ImportStorageRequest request);
        partial void PrepareUpdate2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            global::G.PatchedLseS3ImportStorageRequest request);
        partial void ProcessUpdate2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdate2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ✨ Update import storage<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update a specific S3 import storage connection that was set up with IAM role access.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LseS3ImportStorage> Update2Async(
            int id,

            global::G.PatchedLseS3ImportStorageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdate2Arguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/storages/s3s/{id}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdate2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdate2Response(
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
                ProcessUpdate2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.LseS3ImportStorage.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.LseS3ImportStorage.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// ✨ Update import storage<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update a specific S3 import storage connection that was set up with IAM role access.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="awsAccessKeyId">
        /// AWS_ACCESS_KEY_ID
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS_SECRET_ACCESS_KEY
        /// </param>
        /// <param name="awsSessionToken">
        /// AWS_SESSION_TOKEN
        /// </param>
        /// <param name="awsSseKmsKeyId">
        /// AWS SSE KMS Key ID
        /// </param>
        /// <param name="bucket">
        /// S3 bucket name
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="externalId">
        /// AWS ExternalId
        /// </param>
        /// <param name="lastSync">
        /// Last sync finished time
        /// </param>
        /// <param name="lastSyncCount">
        /// Count of tasks synced last time
        /// </param>
        /// <param name="lastSyncJob">
        /// Last sync job ID
        /// </param>
        /// <param name="legacyAuth"></param>
        /// <param name="meta">
        /// Meta and debug information about storage processes
        /// </param>
        /// <param name="prefix">
        /// S3 bucket prefix
        /// </param>
        /// <param name="presign">
        /// Default Value: true
        /// </param>
        /// <param name="presignTtl">
        /// Presigned URLs TTL (in minutes)
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="recursiveScan">
        /// Perform recursive scan over the bucket content
        /// </param>
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects
        /// </param>
        /// <param name="regionName">
        /// AWS Region
        /// </param>
        /// <param name="roleArn">
        /// AWS RoleArn
        /// </param>
        /// <param name="s3Endpoint">
        /// S3 Endpoint
        /// </param>
        /// <param name="status">
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="traceback">
        /// Traceback report for the last failed sync
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LseS3ImportStorage> Update2Async(
            int id,
            string? awsAccessKeyId = default,
            string? awsSecretAccessKey = default,
            string? awsSessionToken = default,
            string? awsSseKmsKeyId = default,
            string? bucket = default,
            string? description = default,
            string? externalId = default,
            global::System.DateTime? lastSync = default,
            int? lastSyncCount = default,
            string? lastSyncJob = default,
            bool? legacyAuth = default,
            object? meta = default,
            string? prefix = default,
            bool? presign = default,
            int? presignTtl = default,
            int? project = default,
            bool? recursiveScan = default,
            string? regexFilter = default,
            string? regionName = default,
            string? roleArn = default,
            string? s3Endpoint = default,
            global::G.StatusC5aEnum? status = default,
            bool? synchronizable = default,
            string? title = default,
            string? traceback = default,
            bool? useBlobUrls = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PatchedLseS3ImportStorageRequest
            {
                AwsAccessKeyId = awsAccessKeyId,
                AwsSecretAccessKey = awsSecretAccessKey,
                AwsSessionToken = awsSessionToken,
                AwsSseKmsKeyId = awsSseKmsKeyId,
                Bucket = bucket,
                Description = description,
                ExternalId = externalId,
                LastSync = lastSync,
                LastSyncCount = lastSyncCount,
                LastSyncJob = lastSyncJob,
                LegacyAuth = legacyAuth,
                Meta = meta,
                Prefix = prefix,
                Presign = presign,
                PresignTtl = presignTtl,
                Project = project,
                RecursiveScan = recursiveScan,
                RegexFilter = regexFilter,
                RegionName = regionName,
                RoleArn = roleArn,
                S3Endpoint = s3Endpoint,
                Status = status,
                Synchronizable = synchronizable,
                Title = title,
                Traceback = traceback,
                UseBlobUrls = useBlobUrls,
            };

            return await Update2Async(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}