//HintName: G.Api.EndPoints.CreateImageVariation.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Creates a variation of a given image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ImagesResponse> CreateImageVariationAsync(
            CreateImageVariationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/images/variations");
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
        /// Creates a variation of a given image.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="responseFormat"></param>
        /// <param name="size"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ImagesResponse> CreateImageVariationAsync(
            byte[] image,
            object? model,
            int? n,
            CreateImageVariationRequestResponseFormat? responseFormat,
            CreateImageVariationRequestSize? size,
            string? user,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateImageVariationRequest
            {
                Image = image,
                Model = model,
                N = n,
                ResponseFormat = responseFormat,
                Size = size,
                User = user,
            };

            return await CreateImageVariationAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}