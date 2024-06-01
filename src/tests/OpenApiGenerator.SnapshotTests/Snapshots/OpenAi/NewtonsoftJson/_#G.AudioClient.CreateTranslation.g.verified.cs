//HintName: G.AudioClient.CreateTranslation.g.cs

#nullable enable

namespace G
{
    public partial class AudioClient
    {
        /// <summary>
        /// Translates audio into English.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.OneOf<CreateTranslationResponseJson, CreateTranslationResponseVerboseJson>> CreateTranslationAsync(
            CreateTranslationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/audio/translations", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.OneOf<CreateTranslationResponseJson, CreateTranslationResponseVerboseJson>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Translates audio into English.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat"></param>
        /// <param name="temperature"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.OneOf<CreateTranslationResponseJson, CreateTranslationResponseVerboseJson>> CreateTranslationAsync(
            byte[] file,
            global::System.AnyOf<string, CreateTranslationRequestModel> model,
            string? prompt = default,
            string? responseFormat = "json",
            double temperature = 0,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateTranslationRequest
            {
                File = file,
                Model = model,
                Prompt = prompt,
                ResponseFormat = responseFormat,
                Temperature = temperature,
            };

            return await CreateTranslationAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}