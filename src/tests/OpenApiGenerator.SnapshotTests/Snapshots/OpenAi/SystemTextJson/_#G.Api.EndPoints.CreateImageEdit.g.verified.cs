//HintName: G.Api.EndPoints.CreateImageEdit.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Creates an edited or extended image given an original image and a prompt.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ImagesResponse> CreateImageEditAsync(
            CreateImageEditRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/images/edits");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ImagesResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Creates an edited or extended image given an original image and a prompt.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="prompt"></param>
        /// <param name="mask"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="size"></param>
        /// <param name="responseFormat"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ImagesResponse> CreateImageEditAsync(
            byte[] image,
            string prompt,
            byte[]? mask,
            object? model,
            int? n,
            string? size,
            string? responseFormat,
            string? user,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateImageEditRequest
            {
                Image = image,
                Prompt = prompt,
                Mask = mask,
                Model = model,
                N = n,
                Size = size,
                ResponseFormat = responseFormat,
                User = user,
            };

            return await CreateImageEditAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}