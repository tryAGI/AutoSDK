//HintName: G.TranscriptClient.WordSearch.g.cs

#nullable enable

namespace G
{
    public partial class TranscriptClient
    {
        partial void PrepareWordSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string transcriptId,
            global::System.Collections.Generic.IList<string> words);
        partial void PrepareWordSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string transcriptId,
            global::System.Collections.Generic.IList<string> words);
        partial void ProcessWordSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessWordSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search words in transcript<br/>
        /// Search through the transcript for keywords. You can search for individual words, numbers, or phrases containing up to five words or numbers.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="words"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.WordSearchResponse> WordSearchAsync(
            string transcriptId,
            global::System.Collections.Generic.IList<string> words,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareWordSearchArguments(
                httpClient: _httpClient,
                transcriptId: ref transcriptId,
                words: words);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v2/transcript/{transcriptId}/word-search?words={string.Join(",", words)}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareWordSearchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                transcriptId: transcriptId,
                words: words);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessWordSearchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessWordSearchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.WordSearchResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}