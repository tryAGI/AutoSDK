//HintName: G.StoresClient.UpdateStoreFile.g.cs

#nullable enable

namespace G
{
    public partial class StoresClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_UpdateStoreFileSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_UpdateStoreFileSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_UpdateStoreFileSecurityRequirement0,
            };
        partial void PrepareUpdateStoreFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            ref global::G.AnyOf<string, global::System.Guid?> fileIdentifier,
            global::G.StoreFileMetadataUpdateParams request);
        partial void PrepareUpdateStoreFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileIdentifier,
            global::G.StoreFileMetadataUpdateParams request);
        partial void ProcessUpdateStoreFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateStoreFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update store file metadata<br/>
        /// Update metadata on a file within a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     file_identifier: The ID or name of the file to update.<br/>
        ///     update_params: Metadata update payload.<br/>
        /// Returns:<br/>
        ///     StoreFile: The updated file details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="fileIdentifier">
        /// The ID or name of the file to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StoreFile> UpdateStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileIdentifier,

            global::G.StoreFileMetadataUpdateParams request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateStoreFileArguments(
                httpClient: HttpClient,
                storeIdentifier: ref storeIdentifier,
                fileIdentifier: ref fileIdentifier,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UpdateStoreFileSecurityRequirements,
                operationName: "UpdateStoreFileAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/stores/{storeIdentifier}/files/{fileIdentifier}",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareUpdateStoreFileRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                storeIdentifier: storeIdentifier,
                fileIdentifier: fileIdentifier,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateStoreFileResponse(
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
                ProcessUpdateStoreFileResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.StoreFile.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.StoreFile.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Update store file metadata<br/>
        /// Update metadata on a file within a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     file_identifier: The ID or name of the file to update.<br/>
        ///     update_params: Metadata update payload.<br/>
        /// Returns:<br/>
        ///     StoreFile: The updated file details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="fileIdentifier">
        /// The ID or name of the file to update
        /// </param>
        /// <param name="metadata">
        /// Updated metadata for the file
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StoreFile> UpdateStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileIdentifier,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.StoreFileMetadataUpdateParams
            {
                Metadata = metadata,
            };

            return await UpdateStoreFileAsync(
                storeIdentifier: storeIdentifier,
                fileIdentifier: fileIdentifier,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}