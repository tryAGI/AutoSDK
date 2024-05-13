//HintName: G.Api.EndPoints.CreateTranscription.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Transcribes audio into the input language.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTranscriptionAsync(
            CreateTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/audio/transcriptions");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTranscriptionAsync(
            byte[] file,
            object model,
            string? language,
            string? prompt,
            string? responseFormat,
            double temperature,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateTranscriptionRequest
            {
                File = file,
                Model = model,
                Language = language,
                Prompt = prompt,
                ResponseFormat = responseFormat,
                Temperature = temperature,
            };

            await CreateTranscriptionAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}