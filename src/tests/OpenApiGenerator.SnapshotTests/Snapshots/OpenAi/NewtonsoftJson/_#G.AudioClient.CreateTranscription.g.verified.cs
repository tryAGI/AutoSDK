//HintName: G.AudioClient.CreateTranscription.g.cs

#nullable enable

namespace G
{
    public partial class AudioClient
    {
        /// <summary>
        /// Transcribes audio into the input language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.OneOf<global::G.CreateTranscriptionResponseJson, global::G.CreateTranscriptionResponseVerboseJson>> CreateTranscriptionAsync(
            global::G.CreateTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + "/audio/transcriptions", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.OneOf<global::G.CreateTranscriptionResponseJson, global::G.CreateTranscriptionResponseVerboseJson>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Transcribes audio into the input language.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="model"></param>
        /// <param name="language"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat"></param>
        /// <param name="temperature"></param>
        /// <param name="timestampGranularities"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.OneOf<global::G.CreateTranscriptionResponseJson, global::G.CreateTranscriptionResponseVerboseJson>> CreateTranscriptionAsync(
            byte[] file,
            global::System.AnyOf<string, global::G.CreateTranscriptionRequestModel> model,
            string? language = default,
            string? prompt = default,
            global::G.CreateTranscriptionRequestResponseFormat? responseFormat = global::G.CreateTranscriptionRequestResponseFormat.Json,
            double temperature = 0,
            global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularities?>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateTranscriptionRequest
            {
                File = file,
                Model = model,
                Language = language,
                Prompt = prompt,
                ResponseFormat = responseFormat,
                Temperature = temperature,
                TimestampGranularities = timestampGranularities,
            };

            return await CreateTranscriptionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}