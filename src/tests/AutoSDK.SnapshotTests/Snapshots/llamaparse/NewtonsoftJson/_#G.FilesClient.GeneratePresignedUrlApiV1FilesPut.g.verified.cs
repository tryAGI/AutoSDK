//HintName: G.FilesClient.GeneratePresignedUrlApiV1FilesPut.g.cs

#nullable enable

namespace G
{
    public partial class FilesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GeneratePresignedUrlApiV1FilesPutSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_GeneratePresignedUrlApiV1FilesPutSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GeneratePresignedUrlApiV1FilesPutSecurityRequirement0,
            };
        partial void PrepareGeneratePresignedUrlApiV1FilesPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            int? expiresAtSeconds,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session,
            global::G.FileCreate request);
        partial void PrepareGeneratePresignedUrlApiV1FilesPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? expiresAtSeconds,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session,
            global::G.FileCreate request);
        partial void ProcessGeneratePresignedUrlApiV1FilesPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGeneratePresignedUrlApiV1FilesPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate Presigned Url<br/>
        /// Create a presigned URL for uploading a file.<br/>
        /// The URL is valid for a limited time. Use it to upload the file<br/>
        /// content directly to storage via an HTTP PUT request.
        /// </summary>
        /// <param name="expiresAtSeconds"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileIdPresignedUrl> GeneratePresignedUrlApiV1FilesPutAsync(

            global::G.FileCreate request,
            int? expiresAtSeconds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGeneratePresignedUrlApiV1FilesPutArguments(
                httpClient: HttpClient,
                expiresAtSeconds: expiresAtSeconds,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GeneratePresignedUrlApiV1FilesPutSecurityRequirements,
                operationName: "GeneratePresignedUrlApiV1FilesPutAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v1/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("expires_at_seconds", expiresAtSeconds?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("organization_id", organizationId?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            var __cookies = new global::System.Collections.Generic.List<string>();
            var __session = session;
            if (__session is not null)
            {
                __cookies.Add($"session={__session.ToString() ?? string.Empty}");
            }
            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
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
            PrepareGeneratePresignedUrlApiV1FilesPutRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                expiresAtSeconds: expiresAtSeconds,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGeneratePresignedUrlApiV1FilesPutResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
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
                ProcessGeneratePresignedUrlApiV1FilesPutResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.FileIdPresignedUrl.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.FileIdPresignedUrl.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Generate Presigned Url<br/>
        /// Create a presigned URL for uploading a file.<br/>
        /// The URL is valid for a limited time. Use it to upload the file<br/>
        /// content directly to storage via an HTTP PUT request.
        /// </summary>
        /// <param name="expiresAtSeconds"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// Name that will be used for created file. If possible, always include the file extension in the name.
        /// </param>
        /// <param name="externalFileId">
        /// The ID of the file in the external system
        /// </param>
        /// <param name="fileSize">
        /// Size of the file in bytes
        /// </param>
        /// <param name="lastModifiedAt">
        /// The last modified time of the file
        /// </param>
        /// <param name="resourceInfo">
        /// Resource information for the file
        /// </param>
        /// <param name="permissionInfo">
        /// Permission information for the file
        /// </param>
        /// <param name="dataSourceId">
        /// The ID of the data source that the file belongs to
        /// </param>
        /// <param name="storageType">
        /// Storage type for the file. Valid values: 'Ephemeral', 'Permanent' (no expiration). If not specified, defaults to permanent storage.<br/>
        /// Default Value: permanent
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileIdPresignedUrl> GeneratePresignedUrlApiV1FilesPutAsync(
            string name,
            int? expiresAtSeconds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? externalFileId = default,
            long? fileSize = default,
            global::System.DateTime? lastModifiedAt = default,
            object? resourceInfo = default,
            object? permissionInfo = default,
            global::System.Guid? dataSourceId = default,
            global::G.AnyOf<global::G.FileCreateStorageType?, string>? storageType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.FileCreate
            {
                Name = name,
                ExternalFileId = externalFileId,
                FileSize = fileSize,
                LastModifiedAt = lastModifiedAt,
                ResourceInfo = resourceInfo,
                PermissionInfo = permissionInfo,
                DataSourceId = dataSourceId,
                StorageType = storageType,
            };

            return await GeneratePresignedUrlApiV1FilesPutAsync(
                expiresAtSeconds: expiresAtSeconds,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}