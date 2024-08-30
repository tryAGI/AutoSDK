//HintName: G.ModerationClient.GetModerators.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        partial void PrepareGetModeratorsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId,
            ref string? first,
            ref string? after);
        partial void PrepareGetModeratorsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId,
            string? first,
            string? after);
        partial void ProcessGetModeratorsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetModeratorsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets all users allowed to moderate the broadcaster’s chat room.<br/>
        /// Gets all users allowed to moderate the broadcaster’s chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderation:read** scope. If your app also adds and removes moderators, you can use the **channel:manage:moderators** scope instead.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="userId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetModeratorsResponse> GetModeratorsAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId = default,
            string? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetModeratorsArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                userId: userId,
                first: ref first,
                after: ref after);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/moderation/moderators?broadcaster_id={broadcasterId}&{string.Join("&", userId?.Select(static x => $"userId={x}") ?? global::System.Array.Empty<string>())}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetModeratorsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                userId: userId,
                first: first,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetModeratorsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetModeratorsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetModeratorsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}