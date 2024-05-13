//HintName: G.Api.EndPoints.CreateImage.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Creates an image given a prompt.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ImagesResponse> CreateImageAsync(
            CreateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/images/generations");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ImagesResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Creates an image given a prompt.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="quality"></param>
        /// <param name="responseFormat"></param>
        /// <param name="size"></param>
        /// <param name="style"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ImagesResponse> CreateImageAsync(
            string prompt,
            object? model,
            int? n,
            CreateImageRequestQuality? quality,
            CreateImageRequestResponseFormat? responseFormat,
            CreateImageRequestSize? size,
            CreateImageRequestStyle? style,
            string? user,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateImageRequest
            {
                Prompt = prompt,
                Model = model,
                N = n,
                Quality = quality,
                ResponseFormat = responseFormat,
                Size = size,
                Style = style,
                User = user,
            };

            return await CreateImageAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}