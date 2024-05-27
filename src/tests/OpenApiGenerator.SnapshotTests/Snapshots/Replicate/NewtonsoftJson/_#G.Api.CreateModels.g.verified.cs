//HintName: G.Api.CreateModels.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateModelsAsync(
            CreateModelsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/models", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Create a model
        /// </summary>
        /// <param name="coverImageUrl"></param>
        /// <param name="description"></param>
        /// <param name="githubUrl"></param>
        /// <param name="hardware"></param>
        /// <param name="licenseUrl"></param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="paperUrl"></param>
        /// <param name="visibility"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateModelsAsync(
            string hardware,
            string name,
            string owner,
            CreateModelsRequestVisibility visibility,
            string? coverImageUrl = default,
            string? description = default,
            string? githubUrl = default,
            string? licenseUrl = default,
            string? paperUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateModelsRequest
            {
                CoverImageUrl = coverImageUrl,
                Description = description,
                GithubUrl = githubUrl,
                Hardware = hardware,
                LicenseUrl = licenseUrl,
                Name = name,
                Owner = owner,
                PaperUrl = paperUrl,
                Visibility = visibility,
            };

            await CreateModelsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}