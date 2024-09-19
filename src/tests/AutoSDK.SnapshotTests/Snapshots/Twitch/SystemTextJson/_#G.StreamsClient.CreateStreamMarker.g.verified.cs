//HintName: G.StreamsClient.CreateStreamMarker.g.cs

#nullable enable

namespace G
{
    public partial class StreamsClient
    {
        partial void PrepareCreateStreamMarkerArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateStreamMarkerBody request);
        partial void PrepareCreateStreamMarkerRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateStreamMarkerBody request);
        partial void ProcessCreateStreamMarkerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateStreamMarkerResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Adds a marker to a live stream.<br/>
        /// Adds a marker to a live stream. A marker is an arbitrary point in a live stream that the broadcaster or editor wants to mark, so they can return to that spot later to create video highlights (see Video Producer, Highlights in the Twitch UX).<br/>
        /// You may not add markers:<br/>
        /// * If the stream is not live<br/>
        /// * If the stream has not enabled video on demand (VOD)<br/>
        /// * If the stream is a premiere (a live, first-viewing event that combines uploaded videos with live chat)<br/>
        /// * If the stream is a rerun of a past broadcast, including past premieres.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:broadcast** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateStreamMarkerResponse> CreateStreamMarkerAsync(
            global::G.CreateStreamMarkerBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateStreamMarkerArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/streams/markers",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateStreamMarkerRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateStreamMarkerResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateStreamMarkerResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateStreamMarkerResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Adds a marker to a live stream.<br/>
        /// Adds a marker to a live stream. A marker is an arbitrary point in a live stream that the broadcaster or editor wants to mark, so they can return to that spot later to create video highlights (see Video Producer, Highlights in the Twitch UX).<br/>
        /// You may not add markers:<br/>
        /// * If the stream is not live<br/>
        /// * If the stream has not enabled video on demand (VOD)<br/>
        /// * If the stream is a premiere (a live, first-viewing event that combines uploaded videos with live chat)<br/>
        /// * If the stream is a rerun of a past broadcast, including past premieres.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:broadcast** scope.
        /// </summary>
        /// <param name="userId">
        /// The ID of the broadcaster that’s streaming content. This ID must match the user ID in the access token or the user in the access token must be one of the broadcaster’s editors.
        /// </param>
        /// <param name="description">
        /// A short description of the marker to help the user remember why they marked the location. The maximum length of the description is 140 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateStreamMarkerResponse> CreateStreamMarkerAsync(
            string userId,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateStreamMarkerBody
            {
                UserId = userId,
                Description = description,
            };

            return await CreateStreamMarkerAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}