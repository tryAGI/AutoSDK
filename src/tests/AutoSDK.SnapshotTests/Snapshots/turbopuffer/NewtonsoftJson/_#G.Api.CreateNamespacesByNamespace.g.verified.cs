//HintName: G.Api.CreateNamespacesByNamespace.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_CreateNamespacesByNamespaceSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_CreateNamespacesByNamespaceSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CreateNamespacesByNamespaceSecurityRequirement0,
            };
        partial void PrepareCreateNamespacesByNamespaceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace,
            global::G.Write request);
        partial void PrepareCreateNamespacesByNamespaceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace,
            global::G.Write request);
        partial void ProcessCreateNamespacesByNamespaceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateNamespacesByNamespaceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create, update, or delete documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.WriteResult> CreateNamespacesByNamespaceAsync(
            string @namespace,

            global::G.Write request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateNamespacesByNamespaceArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateNamespacesByNamespaceSecurityRequirements,
                operationName: "CreateNamespacesByNamespaceAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v2/namespaces/{@namespace}",
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
            PrepareCreateNamespacesByNamespaceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                @namespace: @namespace,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateNamespacesByNamespaceResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // An error response.
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
                ProcessCreateNamespacesByNamespaceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.WriteResult.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.WriteResult.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create, update, or delete documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="upsertColumns">
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </param>
        /// <param name="upsertRows"></param>
        /// <param name="patchColumns">
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </param>
        /// <param name="patchRows"></param>
        /// <param name="deletes"></param>
        /// <param name="upsertCondition">
        /// A condition evaluated against the current value of each document targeted by an upsert write. Only documents that pass the condition are upserted.
        /// </param>
        /// <param name="patchCondition">
        /// A condition evaluated against the current value of each document targeted by a patch write. Only documents that pass the condition are patched.
        /// </param>
        /// <param name="deleteCondition">
        /// A condition evaluated against the current value of each document targeted by a delete write. Only documents that pass the condition are deleted.
        /// </param>
        /// <param name="distanceMetric">
        /// A function used to calculate vector similarity.
        /// </param>
        /// <param name="schema">
        /// The schema of the attributes attached to the documents.
        /// </param>
        /// <param name="copyFromNamespace"></param>
        /// <param name="deleteByFilter">
        /// The filter specifying which documents to delete.
        /// </param>
        /// <param name="deleteByFilterAllowPartial">
        /// Allow partial completion when filter matches too many documents.
        /// </param>
        /// <param name="patchByFilter">
        /// The patch and filter specifying which documents to patch.
        /// </param>
        /// <param name="patchByFilterAllowPartial">
        /// Allow partial completion when filter matches too many documents.
        /// </param>
        /// <param name="returnAffectedIds">
        /// If true, return the IDs of affected rows (deleted, patched, upserted) in the response. For filtered and conditional writes, only IDs for writes that succeeded will be included.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encryption">
        /// The encryption configuration for a namespace.
        /// </param>
        /// <param name="disableBackpressure">
        /// Disables write throttling (HTTP 429 responses) during high-volume ingestion.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.WriteResult> CreateNamespacesByNamespaceAsync(
            string @namespace,
            global::G.Columns? upsertColumns = default,
            global::System.Collections.Generic.IList<global::G.Row>? upsertRows = default,
            global::G.Columns? patchColumns = default,
            global::System.Collections.Generic.IList<global::G.Row>? patchRows = default,
            global::System.Collections.Generic.IList<global::G.Id>? deletes = default,
            object? upsertCondition = default,
            object? patchCondition = default,
            object? deleteCondition = default,
            global::G.DistanceMetric? distanceMetric = default,
            object? schema = default,
            global::G.OneOf<string, global::G.WriteCopyFromNamespace>? copyFromNamespace = default,
            object? deleteByFilter = default,
            bool? deleteByFilterAllowPartial = default,
            global::G.PatchByFilter? patchByFilter = default,
            bool? patchByFilterAllowPartial = default,
            bool? returnAffectedIds = default,
            global::G.Encryption2? encryption = default,
            bool? disableBackpressure = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Write
            {
                UpsertColumns = upsertColumns,
                UpsertRows = upsertRows,
                PatchColumns = patchColumns,
                PatchRows = patchRows,
                Deletes = deletes,
                UpsertCondition = upsertCondition,
                PatchCondition = patchCondition,
                DeleteCondition = deleteCondition,
                DistanceMetric = distanceMetric,
                Schema = schema,
                CopyFromNamespace = copyFromNamespace,
                DeleteByFilter = deleteByFilter,
                DeleteByFilterAllowPartial = deleteByFilterAllowPartial,
                PatchByFilter = patchByFilter,
                PatchByFilterAllowPartial = patchByFilterAllowPartial,
                ReturnAffectedIds = returnAffectedIds,
                Encryption = encryption,
                DisableBackpressure = disableBackpressure,
            };

            return await CreateNamespacesByNamespaceAsync(
                @namespace: @namespace,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}