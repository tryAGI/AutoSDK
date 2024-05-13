//HintName: G.Api.EndPoints.CreateTranslation.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Translates audio into English.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTranslationAsync(
            CreateTranslationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/audio/translations");
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
        /// Translates audio into English.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat"></param>
        /// <param name="temperature"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTranslationAsync(
            byte[] file,
            object model,
            string? prompt,
            string? responseFormat,
            double temperature,
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

            await CreateTranslationAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}