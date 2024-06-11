//HintName: G.StreamsClient.GetStreams.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class StreamsClient
    {
        /// <summary>
        /// Gets a list of all streams.
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
            var typeValue = type switch
            {
                global::G.GetStreamsType.All => "all",
                global::G.GetStreamsType.Live => "live",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/streams?{string.Join("&", userId.Select(static x => $"userId={x}"))}&{string.Join("&", userLogin.Select(static x => $"userLogin={x}"))}&{string.Join("&", gameId.Select(static x => $"gameId={x}"))}&type={typeValue}&{string.Join("&", language.Select(static x => $"language={x}"))}&first={first}&before={before}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetStreamsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}