//HintName: G.Api.GetTaskDetail.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareGetTaskDetailArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.GetTaskDetailXRunwayVersion xRunwayVersion,
            ref global::System.Guid id);
        partial void PrepareGetTaskDetailRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.GetTaskDetailXRunwayVersion xRunwayVersion,
            global::System.Guid id);
        partial void ProcessGetTaskDetailResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTaskDetailResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get task detail.<br/>
        /// Return details about a task. Updates every 5 seconds.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetTaskDetailResponse> GetTaskDetailAsync(
            global::G.GetTaskDetailXRunwayVersion xRunwayVersion,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetTaskDetailArguments(
                httpClient: HttpClient,
                xRunwayVersion: ref xRunwayVersion,
                id: ref id);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/tasks/{id}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            __httpRequest.Headers.TryAddWithoutValidation("X-Runway-Version", xRunwayVersion.ToValueString());


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetTaskDetailRequest(
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
            ProcessGetTaskDetailResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetTaskDetailResponseContent(
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
                global::G.GetTaskDetailResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}