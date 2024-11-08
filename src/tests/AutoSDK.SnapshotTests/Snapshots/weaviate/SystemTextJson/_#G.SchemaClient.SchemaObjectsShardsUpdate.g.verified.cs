//HintName: G.SchemaClient.SchemaObjectsShardsUpdate.g.cs

#nullable enable

namespace G
{
    public partial class SchemaClient
    {
        partial void PrepareSchemaObjectsShardsUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string className,
            ref string shardName,
            global::G.ShardStatus request);
        partial void PrepareSchemaObjectsShardsUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string className,
            string shardName,
            global::G.ShardStatus request);
        partial void ProcessSchemaObjectsShardsUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSchemaObjectsShardsUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a shard status.<br/>
        /// Update a shard status for a collection. For example, a shard may have been marked as `READONLY` because its disk was full. After providing more disk space, use this endpoint to set the shard status to `READY` again. There is also a convenience function in each client to set the status of all shards of a collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="shardName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ShardStatus> SchemaObjectsShardsUpdateAsync(
            string className,
            string shardName,
            global::G.ShardStatus request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSchemaObjectsShardsUpdateArguments(
                httpClient: HttpClient,
                className: ref className,
                shardName: ref shardName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/schema/{className}/shards/{shardName}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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
            PrepareSchemaObjectsShardsUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                className: className,
                shardName: shardName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSchemaObjectsShardsUpdateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessSchemaObjectsShardsUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::System.InvalidOperationException(__content, __ex);
                }

                return
                    global::G.ShardStatus.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::G.ShardStatus.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Update a shard status.<br/>
        /// Update a shard status for a collection. For example, a shard may have been marked as `READONLY` because its disk was full. After providing more disk space, use this endpoint to set the shard status to `READY` again. There is also a convenience function in each client to set the status of all shards of a collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="shardName"></param>
        /// <param name="status">
        /// Status of the shard
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ShardStatus> SchemaObjectsShardsUpdateAsync(
            string className,
            string shardName,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ShardStatus
            {
                Status = status,
            };

            return await SchemaObjectsShardsUpdateAsync(
                className: className,
                shardName: shardName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}