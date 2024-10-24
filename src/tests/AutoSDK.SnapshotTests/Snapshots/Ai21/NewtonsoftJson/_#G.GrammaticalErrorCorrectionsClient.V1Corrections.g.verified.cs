﻿//HintName: G.GrammaticalErrorCorrectionsClient.V1Corrections.g.cs

#nullable enable

namespace G
{
    public partial class GrammaticalErrorCorrectionsClient
    {
        partial void PrepareV1CorrectionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CorrectionsBody request);
        partial void PrepareV1CorrectionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CorrectionsBody request);
        partial void ProcessV1CorrectionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1CorrectionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Grammatical Error Corrections
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CorrectionsResponse> V1CorrectionsAsync(
            global::G.CorrectionsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1CorrectionsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/gec",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareV1CorrectionsRequest(
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
            ProcessV1CorrectionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1CorrectionsResponseContent(
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
                global::G.CorrectionsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Grammatical Error Corrections
        /// </summary>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CorrectionsResponse> V1CorrectionsAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CorrectionsBody
            {
                Text = text,
            };

            return await V1CorrectionsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}