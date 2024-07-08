//HintName: G.StreamsClient.GetStreams.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class StreamsClient
    {
        partial void PrepareGetStreamsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string> userId,
            global::System.Collections.Generic.IList<string> userLogin,
            global::System.Collections.Generic.IList<string> gameId,
            ref global::G.GetStreamsType type,
            global::System.Collections.Generic.IList<string> language,
            ref int first,
            ref string before,
            ref string after);
        partial void PrepareGetStreamsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string> userId,
            global::System.Collections.Generic.IList<string> userLogin,
            global::System.Collections.Generic.IList<string> gameId,
            global::G.GetStreamsType type,
            global::System.Collections.Generic.IList<string> language,
            int first,
            string before,
            string after);
        partial void ProcessGetStreamsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetStreamsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets a list of all streams.<br/>
        /// Gets a list of all streams. The list is in descending order by the number of viewers watching the stream. Because viewers come and go during a stream, it’s possible to find duplicate or missing streams in the list as you page through the results.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userLogin"></param>
        /// <param name="gameId"></param>
        /// <param name="type"></param>
        /// <param name="language"></param>
        /// <param name="first"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetStreamsResponse> GetStreamsAsync(
            global::System.Collections.Generic.IList<string> userId,
            global::System.Collections.Generic.IList<string> userLogin,
            global::System.Collections.Generic.IList<string> gameId,
            global::G.GetStreamsType type,
            global::System.Collections.Generic.IList<string> language,
            int first,
            string before,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetStreamsArguments(
                httpClient: _httpClient,
                userId: userId,
                userLogin: userLogin,
                gameId: gameId,
                type: ref type,
                language: language,
                first: ref first,
                before: ref before,
                after: ref after);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/streams?{string.Join("&", userId.Select(static x => $"userId={x}"))}&{string.Join("&", userLogin.Select(static x => $"userLogin={x}"))}&{string.Join("&", gameId.Select(static x => $"gameId={x}"))}&type={type}&{string.Join("&", language.Select(static x => $"language={x}"))}&first={first}&before={before}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetStreamsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId,
                userLogin: userLogin,
                gameId: gameId,
                type: type,
                language: language,
                first: first,
                before: before,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetStreamsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetStreamsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetStreamsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}