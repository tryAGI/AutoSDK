//HintName: G.AudioClient.CreateSpeech.g.cs

#nullable enable

namespace G
{
    public partial class AudioClient
    {
        /// <summary>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            CreateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/audio/speech", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<byte[]?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="voice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="speed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            global::System.AnyOf<string, CreateSpeechRequestModel> model,
            string input,
            CreateSpeechRequestVoice voice,
            CreateSpeechRequestResponseFormat? responseFormat = CreateSpeechRequestResponseFormat.Mp3,
            double speed = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateSpeechRequest
            {
                Model = model,
                Input = input,
                Voice = voice,
                ResponseFormat = responseFormat,
                Speed = speed,
            };

            return await CreateSpeechAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}