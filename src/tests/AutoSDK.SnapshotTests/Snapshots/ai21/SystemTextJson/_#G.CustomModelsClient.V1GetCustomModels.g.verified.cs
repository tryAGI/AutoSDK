﻿//HintName: G.CustomModelsClient.V1GetCustomModels.g.cs

#nullable enable

namespace G
{
    public partial class CustomModelsClient
    {
        partial void PrepareV1GetCustomModelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? includeMetadata,
            ref int? requestStartTime);
        partial void PrepareV1GetCustomModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? includeMetadata,
            int? requestStartTime);
        partial void ProcessV1GetCustomModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1GetCustomModelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Custom Models List
        /// </summary>
        /// <param name="includeMetadata">
        /// Default Value: false
        /// </param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1GetCustomModelsAsync(
            bool? includeMetadata = default,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareV1GetCustomModelsArguments(
                httpClient: HttpClient,
                includeMetadata: ref includeMetadata,
                requestStartTime: ref requestStartTime);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/studio/v1/custom-model",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("includeMetadata", includeMetadata?.ToString()) 
                .AddOptionalParameter("request_start_time", requestStartTime?.ToString()) 
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
            PrepareV1GetCustomModelsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                includeMetadata: includeMetadata,
                requestStartTime: requestStartTime);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1GetCustomModelsResponse(
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
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
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
                ProcessV1GetCustomModelsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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

                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
                }
                catch (global::System.Exception __ex)
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
            }
        }
    }
}