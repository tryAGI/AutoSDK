//HintName: G.TrackingClient.GetRequestSearchSuggestions.g.cs

#nullable enable

namespace G
{
    public partial class TrackingClient
    {
        partial void PrepareGetRequestSearchSuggestionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.GetRequestSearchSuggestionsField field,
            ref string? prefix,
            ref string? metadataKey,
            ref int? promptId,
            ref string? filterGroup);
        partial void PrepareGetRequestSearchSuggestionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.GetRequestSearchSuggestionsField field,
            string? prefix,
            string? metadataKey,
            int? promptId,
            string? filterGroup);
        partial void ProcessGetRequestSearchSuggestionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetRequestSearchSuggestionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search Request Suggestions
        /// </summary>
        /// <param name="field"></param>
        /// <param name="prefix"></param>
        /// <param name="metadataKey"></param>
        /// <param name="promptId"></param>
        /// <param name="filterGroup"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetRequestSearchSuggestionsResponse> GetRequestSearchSuggestionsAsync(
            global::G.GetRequestSearchSuggestionsField field,
            string? prefix = default,
            string? metadataKey = default,
            int? promptId = default,
            string? filterGroup = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetRequestSearchSuggestionsArguments(
                httpClient: HttpClient,
                field: ref field,
                prefix: ref prefix,
                metadataKey: ref metadataKey,
                promptId: ref promptId,
                filterGroup: ref filterGroup);

            var fieldValue = field switch
            {
                global::G.GetRequestSearchSuggestionsField.Engine => "engine",
                global::G.GetRequestSearchSuggestionsField.ProviderType => "provider_type",
                global::G.GetRequestSearchSuggestionsField.PromptId => "prompt_id",
                global::G.GetRequestSearchSuggestionsField.Prompt => "prompt",
                global::G.GetRequestSearchSuggestionsField.Tags => "tags",
                global::G.GetRequestSearchSuggestionsField.MetadataKeys => "metadata_keys",
                global::G.GetRequestSearchSuggestionsField.Status => "status",
                global::G.GetRequestSearchSuggestionsField.ToolNames => "tool_names",
                global::G.GetRequestSearchSuggestionsField.OutputKeys => "output_keys",
                global::G.GetRequestSearchSuggestionsField.InputVariableKeys => "input_variable_keys",
                global::G.GetRequestSearchSuggestionsField.MetadataValues => "metadata_values",
                global::G.GetRequestSearchSuggestionsField.OutputValues => "output_values",
                global::G.GetRequestSearchSuggestionsField.InputVariableValues => "input_variable_values",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/public/v2/requests/suggestions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("field", field.ToValueString())
                .AddOptionalParameter("prefix", prefix)
                .AddOptionalParameter("metadata_key", metadataKey)
                .AddOptionalParameter("prompt_id", promptId?.ToString())
                .AddOptionalParameter("filter_group", filterGroup) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetRequestSearchSuggestionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                field: field,
                prefix: prefix,
                metadataKey: metadataKey,
                promptId: promptId,
                filterGroup: filterGroup);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetRequestSearchSuggestionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Authentication failed.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.ErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.ErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.ErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
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
            // Invalid workspace.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.ErrorResponse? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.ErrorResponse.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.ErrorResponse.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
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
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
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
                ProcessGetRequestSearchSuggestionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetRequestSearchSuggestionsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetRequestSearchSuggestionsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}