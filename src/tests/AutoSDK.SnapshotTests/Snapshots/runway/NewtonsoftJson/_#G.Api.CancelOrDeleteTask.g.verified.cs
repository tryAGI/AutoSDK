//HintName: G.Api.CancelOrDeleteTask.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCancelOrDeleteTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.CancelOrDeleteTaskXRunwayVersion xRunwayVersion,
            ref global::System.Guid id);
        partial void PrepareCancelOrDeleteTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CancelOrDeleteTaskXRunwayVersion xRunwayVersion,
            global::System.Guid id);
        partial void ProcessCancelOrDeleteTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Cancel or delete a task.<br/>
        /// Cancel a running task or delete a completed one.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CancelOrDeleteTaskAsync(
            global::G.CancelOrDeleteTaskXRunwayVersion xRunwayVersion,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCancelOrDeleteTaskArguments(
                httpClient: _httpClient,
                xRunwayVersion: ref xRunwayVersion,
                id: ref id);

            var xRunwayVersionValue = xRunwayVersion switch
            {
                global::G.CancelOrDeleteTaskXRunwayVersion.x20240913 => "2024-09-13",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/v1/tasks/{id}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
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

            httpRequest.Headers.TryAddWithoutValidation("X-Runway-Version", xRunwayVersion.ToValueString());


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCancelOrDeleteTaskRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xRunwayVersion: xRunwayVersion,
                id: id);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCancelOrDeleteTaskResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}