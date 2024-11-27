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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CancelOrDeleteTaskAsync(
            global::G.CancelOrDeleteTaskXRunwayVersion xRunwayVersion,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCancelOrDeleteTaskArguments(
                httpClient: HttpClient,
                xRunwayVersion: ref xRunwayVersion,
                id: ref id);

            var xRunwayVersionValue = xRunwayVersion switch
            {
                global::G.CancelOrDeleteTaskXRunwayVersion.x20240913 => "2024-09-13",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/v1/tasks/{id}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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

            __httpRequest.Headers.TryAddWithoutValidation("X-Runway-Version", xRunwayVersion.ToValueString());


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCancelOrDeleteTaskRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xRunwayVersion: xRunwayVersion,
                id: id);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCancelOrDeleteTaskResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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
        }
    }
}