//HintName: G.SnapshotsClient.RecoverFromUploadedSnapshot.g.cs

#nullable enable

namespace G
{
    public partial class SnapshotsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_RecoverFromUploadedSnapshotSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_RecoverFromUploadedSnapshotSecurityRequirement1 =
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

        private static readonly global::G.EndPointSecurityRequirement s_RecoverFromUploadedSnapshotSecurityRequirement2 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_RecoverFromUploadedSnapshotSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_RecoverFromUploadedSnapshotSecurityRequirement0,
                s_RecoverFromUploadedSnapshotSecurityRequirement1,
                s_RecoverFromUploadedSnapshotSecurityRequirement2,
            };
        partial void PrepareRecoverFromUploadedSnapshotArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionName,
            ref bool? wait,
            ref global::G.SnapshotPriority? priority,
            ref string? checksum,
            global::G.RecoverFromUploadedSnapshotRequest request);
        partial void PrepareRecoverFromUploadedSnapshotRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionName,
            bool? wait,
            global::G.SnapshotPriority? priority,
            string? checksum,
            global::G.RecoverFromUploadedSnapshotRequest request);
        partial void ProcessRecoverFromUploadedSnapshotResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRecoverFromUploadedSnapshotResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Recover from an uploaded snapshot<br/>
        /// Recover local collection data from an uploaded snapshot. This will overwrite any data, stored on this node, for the collection. If collection does not exist - it will be created.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="priority">
        /// Defines source of truth for snapshot recovery:<br/>
        /// `NoSync` means - restore snapshot without *any* additional synchronization. `Snapshot` means - prefer snapshot data over the current state. `Replica` means - prefer existing data over the snapshot.
        /// </param>
        /// <param name="checksum"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RecoverFromUploadedSnapshotResponse> RecoverFromUploadedSnapshotAsync(
            string collectionName,

            global::G.RecoverFromUploadedSnapshotRequest request,
            bool? wait = default,
            global::G.SnapshotPriority? priority = default,
            string? checksum = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRecoverFromUploadedSnapshotArguments(
                httpClient: HttpClient,
                collectionName: ref collectionName,
                wait: ref wait,
                priority: ref priority,
                checksum: ref checksum,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RecoverFromUploadedSnapshotSecurityRequirements,
                operationName: "RecoverFromUploadedSnapshotAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/collections/{collectionName}/snapshots/upload",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("wait", wait?.ToString().ToLowerInvariant())
                .AddOptionalParameter("priority", priority?.ToValueString())
                .AddOptionalParameter("checksum", checksum) 
                ;
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{collectionName}"),
                name: "\"collection_name\"");
            if (wait != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{wait}"),
                    name: "\"wait\"");
            } 
            if (priority != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{priority?.ToValueString()}"),
                    name: "\"priority\"");
            } 
            if (checksum != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{checksum}"),
                    name: "\"checksum\"");
            } 
            if (request.Snapshot != default)
            {

                var __contentSnapshot = new global::System.Net.Http.ByteArrayContent(request.Snapshot ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentSnapshot,
                    name: "\"snapshot\"",
                    fileName: request.Snapshotname != null ? $"\"{request.Snapshotname}\"" : string.Empty);
                if (__contentSnapshot.Headers.ContentDisposition != null)
                {
                    __contentSnapshot.Headers.ContentDisposition.FileNameStar = null;
                }
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRecoverFromUploadedSnapshotRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                collectionName: collectionName,
                wait: wait,
                priority: priority,
                checksum: checksum,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRecoverFromUploadedSnapshotResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // error
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::System.Exception? __exception_4XX = null;
                global::G.ErrorResponse? __value_4XX = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_4XX = global::G.ErrorResponse.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_4XX = global::G.ErrorResponse.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_4XX = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_4XX,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_4XX,
                    ResponseObject = __value_4XX,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // error
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                global::G.ErrorResponse? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::G.ErrorResponse.FromJson(__content_default, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::G.ErrorResponse.FromJson(__content_default, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
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
                ProcessRecoverFromUploadedSnapshotResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.RecoverFromUploadedSnapshotResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.RecoverFromUploadedSnapshotResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Recover from an uploaded snapshot<br/>
        /// Recover local collection data from an uploaded snapshot. This will overwrite any data, stored on this node, for the collection. If collection does not exist - it will be created.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="priority">
        /// Defines source of truth for snapshot recovery:<br/>
        /// `NoSync` means - restore snapshot without *any* additional synchronization. `Snapshot` means - prefer snapshot data over the current state. `Replica` means - prefer existing data over the snapshot.
        /// </param>
        /// <param name="checksum"></param>
        /// <param name="snapshot"></param>
        /// <param name="snapshotname"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RecoverFromUploadedSnapshotResponse> RecoverFromUploadedSnapshotAsync(
            string collectionName,
            bool? wait = default,
            global::G.SnapshotPriority? priority = default,
            string? checksum = default,
            byte[]? snapshot = default,
            string? snapshotname = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.RecoverFromUploadedSnapshotRequest
            {
                Snapshot = snapshot,
                Snapshotname = snapshotname,
            };

            return await RecoverFromUploadedSnapshotAsync(
                collectionName: collectionName,
                wait: wait,
                priority: priority,
                checksum: checksum,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}