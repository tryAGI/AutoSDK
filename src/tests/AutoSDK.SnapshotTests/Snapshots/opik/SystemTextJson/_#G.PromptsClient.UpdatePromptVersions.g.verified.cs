//HintName: G.PromptsClient.UpdatePromptVersions.g.cs

#nullable enable

namespace G
{
    public partial class PromptsClient
    {
        partial void PrepareUpdatePromptVersionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PromptVersionBatchUpdate request);
        partial void PrepareUpdatePromptVersionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PromptVersionBatchUpdate request);
        partial void ProcessUpdatePromptVersionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update prompt versions<br/>
        /// Update one or more prompt versions.<br/>
        /// Note: Prompt versions are immutable by design.<br/>
        /// Only organizational properties, such as tags etc., can be updated.<br/>
        /// Core properties like template and metadata cannot be modified after creation.<br/>
        /// PATCH semantics:<br/>
        /// - non-empty values update the field<br/>
        /// - null values preserve existing field values (no change)<br/>
        /// - empty values explicitly clear the field
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UpdatePromptVersionsAsync(

            global::G.PromptVersionBatchUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdatePromptVersionsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/prompts/versions",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareUpdatePromptVersionsRequest(
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
            ProcessUpdatePromptVersionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.ErrorMessage? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.ErrorMessage.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.ErrorMessage.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorMessage>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
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
        /// Update prompt versions<br/>
        /// Update one or more prompt versions.<br/>
        /// Note: Prompt versions are immutable by design.<br/>
        /// Only organizational properties, such as tags etc., can be updated.<br/>
        /// Core properties like template and metadata cannot be modified after creation.<br/>
        /// PATCH semantics:<br/>
        /// - non-empty values update the field<br/>
        /// - null values preserve existing field values (no change)<br/>
        /// - empty values explicitly clear the field
        /// </summary>
        /// <param name="ids">
        /// IDs of prompt versions to update
        /// </param>
        /// <param name="update">
        /// Update to apply to prompt versions.<br/>
        /// Note: Prompt versions are immutable by design.<br/>
        /// Only organizational properties (such as tags etc.) can be updated.<br/>
        /// Core properties like template, metadata etc. cannot be modified after creation.
        /// </param>
        /// <param name="mergeTags">
        /// Tag merge behavior:<br/>
        /// - true: Add new tags to existing tags (union)<br/>
        /// - false: Replace all existing tags with new tags (default behaviour if not provided)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdatePromptVersionsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.PromptVersionUpdate update,
            bool? mergeTags = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PromptVersionBatchUpdate
            {
                Ids = ids,
                Update = update,
                MergeTags = mergeTags,
            };

            await UpdatePromptVersionsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}