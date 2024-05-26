﻿//HintName: G.ImagesClient.CreateImageEdit.g.cs

#nullable enable

namespace G
{
    public partial class ImagesClient
    {
        /// <summary>
        /// Creates an edited or extended image given an original image and a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ImagesResponse> CreateImageEditAsync(
            CreateImageEditRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/images/edits", global::System.UriKind.RelativeOrAbsolute));
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
            byte[]? mask = default,
            object? model = default,
            int? n = 1,
            CreateImageEditRequestSize? size = CreateImageEditRequestSize._1024x1024,
            CreateImageEditRequestResponseFormat? responseFormat = CreateImageEditRequestResponseFormat.Url,
            string? user = default,
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

            return await CreateImageEditAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}