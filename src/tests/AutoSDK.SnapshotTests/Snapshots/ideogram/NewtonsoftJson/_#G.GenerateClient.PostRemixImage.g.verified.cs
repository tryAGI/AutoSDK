//HintName: G.GenerateClient.PostRemixImage.g.cs

#nullable enable

namespace G
{
    public partial class GenerateClient
    {
        partial void PreparePostRemixImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.RemixImageRequest request);
        partial void PreparePostRemixImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.RemixImageRequest request);
        partial void ProcessPostRemixImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostRemixImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remix provided images synchronously based on a given prompt and optional parameters<br/>
        /// A request to remix a provided image with Ideogram. Input images<br/>
        /// are cropped to the chosen aspect ratio before being remixed.<br/>
        /// Supported image formats include JPEG, PNG, and WEBP
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GenerateImageResponse> PostRemixImageAsync(
            global::G.RemixImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostRemixImageArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/remix",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.ImageRequest}"),
                name: "image_request");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "image_file",
                fileName: request.ImageFilename ?? string.Empty);
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostRemixImageRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPostRemixImageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPostRemixImageResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.GenerateImageResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Remix provided images synchronously based on a given prompt and optional parameters<br/>
        /// A request to remix a provided image with Ideogram. Input images<br/>
        /// are cropped to the chosen aspect ratio before being remixed.<br/>
        /// Supported image formats include JPEG, PNG, and WEBP
        /// </summary>
        /// <param name="imageRequest">
        /// A request to generate a new image using a provided image and a prompt.
        /// </param>
        /// <param name="imageFile">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="imageFilename">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GenerateImageResponse> PostRemixImageAsync(
            global::G.InitialImageRequest imageRequest,
            byte[] imageFile,
            string imageFilename,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.RemixImageRequest
            {
                ImageRequest = imageRequest,
                ImageFile = imageFile,
                ImageFilename = imageFilename,
            };

            return await PostRemixImageAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}