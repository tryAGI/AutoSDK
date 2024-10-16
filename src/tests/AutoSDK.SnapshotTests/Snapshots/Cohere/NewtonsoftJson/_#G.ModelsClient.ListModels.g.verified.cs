﻿//HintName: G.ModelsClient.ListModels.g.cs

#nullable enable

namespace G
{
    public partial class ModelsClient
    {
        partial void PrepareListModelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref double? pageSize,
            ref string? pageToken,
            ref global::G.CompatibleEndpoint? endpoint,
            ref bool? defaultOnly);
        partial void PrepareListModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            double? pageSize,
            string? pageToken,
            global::G.CompatibleEndpoint? endpoint,
            bool? defaultOnly);
        partial void ProcessListModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListModelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Models<br/>
        /// Returns a list of models available for use. The list contains models from Cohere as well as your fine-tuned models.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="endpoint">
        /// One of the Cohere API endpoints that the model can be used with.
        /// </param>
        /// <param name="defaultOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListModelsResponse> ListModelsAsync(
            double? pageSize = default,
            string? pageToken = default,
            global::G.CompatibleEndpoint? endpoint = default,
            bool? defaultOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListModelsArguments(
                httpClient: _httpClient,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                endpoint: ref endpoint,
                defaultOnly: ref defaultOnly);

            var endpointValue = endpoint switch
            {
                global::G.CompatibleEndpoint.Chat => "chat",
                global::G.CompatibleEndpoint.Embed => "embed",
                global::G.CompatibleEndpoint.Classify => "classify",
                global::G.CompatibleEndpoint.Summarize => "summarize",
                global::G.CompatibleEndpoint.Rerank => "rerank",
                global::G.CompatibleEndpoint.Rate => "rate",
                global::G.CompatibleEndpoint.Generate => "generate",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/v1/models",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("page_token", pageToken) 
                .AddOptionalParameter("endpoint", endpointValue?.ToString()) 
                .AddOptionalParameter("default_only", defaultOnly?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListModelsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pageSize: pageSize,
                pageToken: pageToken,
                endpoint: endpoint,
                defaultOnly: defaultOnly);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListModelsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListModelsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::G.ListModelsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}