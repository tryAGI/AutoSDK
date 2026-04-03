//HintName: G.StorageDatabricksFilesClient.Validate2.g.cs

#nullable enable

namespace G
{
    public partial class StorageDatabricksFilesClient
    {
        partial void PrepareValidate2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.DatabricksExportStorageRequest request);
        partial void PrepareValidate2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.DatabricksExportStorageRequest request);
        partial void ProcessValidate2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// ✨ Validate Databricks export storage<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Validate a specific Databricks Files export storage connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task Validate2Async(

            global::G.DatabricksExportStorageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareValidate2Arguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/storages/export/databricks/validate",
                baseUri: HttpClient.BaseAddress); 
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareValidate2Request(
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
            ProcessValidate2Response(
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
        /// <summary>
        /// ✨ Validate Databricks export storage<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Validate a specific Databricks Files export storage connection.
        /// </summary>
        /// <param name="authType">
        /// Authentication method: PAT, Databricks SP, or Azure AD SP<br/>
        /// * `pat` - Personal Access Token<br/>
        /// * `dbx_sp` - Databricks Service Principal<br/>
        /// * `azure_ad_sp` - Azure AD Service Principal<br/>
        /// Default Value: pat
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="catalog">
        /// UC catalog name
        /// </param>
        /// <param name="clientId">
        /// Service principal client/application ID (required for SP modes)
        /// </param>
        /// <param name="clientSecret">
        /// Service principal client secret (required for SP modes)<br/>
        /// Included only in requests
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="host">
        /// Databricks workspace base URL (https://...)
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
        /// <param name="meta">
        /// Meta and debug information about storage processes
        /// </param>
        /// <param name="prefix">
        /// Export path prefix under the volume
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="regexFilter">
        /// Regex for filtering objects
        /// </param>
        /// <param name="requestTimeoutS"></param>
        /// <param name="schema">
        /// UC schema name
        /// </param>
        /// <param name="status">
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </param>
        /// <param name="streamChunkBytes"></param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="tenantId">
        /// Azure AD tenant ID (required for Azure AD SP mode)
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="token">
        /// Databricks personal access token (required for PAT mode)<br/>
        /// Included only in requests
        /// </param>
        /// <param name="traceback">
        /// Traceback report for the last failed sync
        /// </param>
        /// <param name="useBlobUrls">
        /// Generate blob URLs in tasks
        /// </param>
        /// <param name="verifyTls">
        /// Verify TLS certificates
        /// </param>
        /// <param name="volume">
        /// UC volume name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task Validate2Async(
            string catalog,
            string clientSecret,
            string host,
            int project,
            string schema,
            string token,
            string volume,
            global::G.AuthTypeEnum? authType = default,
            bool? canDeleteObjects = default,
            string? clientId = default,
            string? description = default,
            global::System.DateTime? lastSync = default,
            int? lastSyncCount = default,
            string? lastSyncJob = default,
            object? meta = default,
            string? prefix = default,
            string? regexFilter = default,
            int? requestTimeoutS = default,
            global::G.StatusC5aEnum? status = default,
            long? streamChunkBytes = default,
            bool? synchronizable = default,
            string? tenantId = default,
            string? title = default,
            string? traceback = default,
            bool? useBlobUrls = default,
            bool? verifyTls = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.DatabricksExportStorageRequest
            {
                AuthType = authType,
                CanDeleteObjects = canDeleteObjects,
                Catalog = catalog,
                ClientId = clientId,
                ClientSecret = clientSecret,
                Description = description,
                Host = host,
                LastSync = lastSync,
                LastSyncCount = lastSyncCount,
                LastSyncJob = lastSyncJob,
                Meta = meta,
                Prefix = prefix,
                Project = project,
                RegexFilter = regexFilter,
                RequestTimeoutS = requestTimeoutS,
                Schema = schema,
                Status = status,
                StreamChunkBytes = streamChunkBytes,
                Synchronizable = synchronizable,
                TenantId = tenantId,
                Title = title,
                Token = token,
                Traceback = traceback,
                UseBlobUrls = useBlobUrls,
                VerifyTls = verifyTls,
                Volume = volume,
            };

            await Validate2Async(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}