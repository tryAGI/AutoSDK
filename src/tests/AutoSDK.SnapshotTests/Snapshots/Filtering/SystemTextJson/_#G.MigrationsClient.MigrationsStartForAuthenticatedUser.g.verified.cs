//HintName: G.MigrationsClient.MigrationsStartForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsStartForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.MigrationsStartForAuthenticatedUserRequest request);
        partial void PrepareMigrationsStartForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.MigrationsStartForAuthenticatedUserRequest request);
        partial void ProcessMigrationsStartForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsStartForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start a user migration<br/>
        /// Initiates the generation of a user migration archive.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Migration> MigrationsStartForAuthenticatedUserAsync(
            global::G.MigrationsStartForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMigrationsStartForAuthenticatedUserArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/user/migrations",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMigrationsStartForAuthenticatedUserRequest(
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
            ProcessMigrationsStartForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation failed, or the endpoint has been spammed.
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.ValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.ValidationError.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.ValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ValidationError>(
                    message: __response.ReasonPhrase ?? string.Empty,
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
            // 
            if ((int)__response.StatusCode == 304)
            {
                string? __content_304 = null;
                if (ReadResponseAsString)
                {
                    __content_304 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_304 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_304,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::G.BasicError? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::G.BasicError.FromJson(__content_403, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Requires authentication
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::G.BasicError? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::G.BasicError.FromJson(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessMigrationsStartForAuthenticatedUserResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.Migration.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.Migration.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Start a user migration<br/>
        /// Initiates the generation of a user migration archive.
        /// </summary>
        /// <param name="lockRepositories">
        /// Lock the repositories being migrated at the start of the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeMetadata">
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeGitData">
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeAttachments">
        /// Do not include attachments in the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeReleases">
        /// Do not include releases in the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeOwnerProjects">
        /// Indicates whether projects owned by the organization or users should be excluded.<br/>
        /// Example: true
        /// </param>
        /// <param name="orgMetadataOnly">
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="exclude">
        /// Exclude attributes from the API response to improve performance<br/>
        /// Example: [repositories]
        /// </param>
        /// <param name="repositories"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Migration> MigrationsStartForAuthenticatedUserAsync(
            global::System.Collections.Generic.IList<string> repositories,
            bool? lockRepositories = default,
            bool? excludeMetadata = default,
            bool? excludeGitData = default,
            bool? excludeAttachments = default,
            bool? excludeReleases = default,
            bool? excludeOwnerProjects = default,
            bool? orgMetadataOnly = default,
            global::System.Collections.Generic.IList<global::G.MigrationsStartForAuthenticatedUserRequestExcludeItem>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.MigrationsStartForAuthenticatedUserRequest
            {
                LockRepositories = lockRepositories,
                ExcludeMetadata = excludeMetadata,
                ExcludeGitData = excludeGitData,
                ExcludeAttachments = excludeAttachments,
                ExcludeReleases = excludeReleases,
                ExcludeOwnerProjects = excludeOwnerProjects,
                OrgMetadataOnly = orgMetadataOnly,
                Exclude = exclude,
                Repositories = repositories,
            };

            return await MigrationsStartForAuthenticatedUserAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}