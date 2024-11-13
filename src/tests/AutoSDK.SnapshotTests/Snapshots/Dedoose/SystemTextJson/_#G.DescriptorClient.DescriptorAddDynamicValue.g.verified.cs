//HintName: G.DescriptorClient.DescriptorAddDynamicValue.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorAddDynamicValueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref global::System.Guid? setId,
            ref global::System.Guid? descriptorId,
            ref global::System.Guid? fieldId,
            ref global::System.Guid? resourceId,
            ref string? data,
            ref global::System.Guid? optionId);
        partial void PrepareDescriptorAddDynamicValueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Guid? setId,
            global::System.Guid? descriptorId,
            global::System.Guid? fieldId,
            global::System.Guid? resourceId,
            string? data,
            global::System.Guid? optionId);
        partial void ProcessDescriptorAddDynamicValueResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorAddDynamicValueResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddDynamicValue.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="fieldId"></param>
        /// <param name="resourceId"></param>
        /// <param name="data"></param>
        /// <param name="optionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> DescriptorAddDynamicValueAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? setId = default,
            global::System.Guid? descriptorId = default,
            global::System.Guid? fieldId = default,
            global::System.Guid? resourceId = default,
            string? data = default,
            global::System.Guid? optionId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDescriptorAddDynamicValueArguments(
                httpClient: HttpClient,
                token: ref token,
                projectId: ref projectId,
                setId: ref setId,
                descriptorId: ref descriptorId,
                fieldId: ref fieldId,
                resourceId: ref resourceId,
                data: ref data,
                optionId: ref optionId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/descriptor/adddynamicvalue",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("setId", setId?.ToString()) 
                .AddOptionalParameter("descriptorId", descriptorId?.ToString()) 
                .AddOptionalParameter("fieldId", fieldId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("data", data) 
                .AddOptionalParameter("optionId", optionId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDescriptorAddDynamicValueRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectId: projectId,
                setId: setId,
                descriptorId: descriptorId,
                fieldId: fieldId,
                resourceId: resourceId,
                data: data,
                optionId: optionId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDescriptorAddDynamicValueResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Token is null.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                string? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
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
            // Token is invalid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
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
                ProcessDescriptorAddDynamicValueResponseContent(
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

                return __content;
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

                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                return __content;
            }
        }
    }
}