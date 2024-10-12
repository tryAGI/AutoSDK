//HintName: G.RunClient.ListRules.g.cs

#nullable enable

namespace G
{
    public partial class RunClient
    {
        partial void PrepareListRulesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid? datasetId,
            ref global::System.Guid? sessionId,
            ref global::G.ListRulesApiV1RunsRulesGetType? type,
            ref string? nameContains);
        partial void PrepareListRulesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? datasetId,
            global::System.Guid? sessionId,
            global::G.ListRulesApiV1RunsRulesGetType? type,
            string? nameContains);
        partial void ProcessListRulesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRulesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Rules<br/>
        /// List all run rules.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionId"></param>
        /// <param name="type"></param>
        /// <param name="nameContains"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RunRulesSchema>> ListRulesAsync(
            global::System.Guid? datasetId = default,
            global::System.Guid? sessionId = default,
            global::G.ListRulesApiV1RunsRulesGetType? type = default,
            string? nameContains = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListRulesArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                sessionId: ref sessionId,
                type: ref type,
                nameContains: ref nameContains);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/runs/rules",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("dataset_id", datasetId?.ToString()) 
                .AddOptionalParameter("session_id", sessionId?.ToString()) 
                .AddOptionalParameter("type", type?.ToValueString()) 
                .AddOptionalParameter("name_contains", nameContains) 
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
            PrepareListRulesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                sessionId: sessionId,
                type: type,
                nameContains: nameContains);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListRulesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListRulesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.RunRulesSchema>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}