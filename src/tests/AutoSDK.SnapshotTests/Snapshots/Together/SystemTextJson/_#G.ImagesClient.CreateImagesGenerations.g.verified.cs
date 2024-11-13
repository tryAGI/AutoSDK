//HintName: G.ImagesClient.CreateImagesGenerations.g.cs

#nullable enable

namespace G
{
    public partial class ImagesClient
    {
        partial void PrepareCreateImagesGenerationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Request2 request);
        partial void PrepareCreateImagesGenerationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Request2 request);
        partial void ProcessCreateImagesGenerationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateImagesGenerationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create image<br/>
        /// Use an image model to generate an image for a given prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ImageResponse> CreateImagesGenerationsAsync(
            global::G.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateImagesGenerationsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/images/generations",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateImagesGenerationsRequest(
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
            ProcessCreateImagesGenerationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateImagesGenerationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.ImageResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.ImageResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create image<br/>
        /// Use an image model to generate an image for a given prompt.
        /// </summary>
        /// <param name="height">
        /// Height of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="model">
        /// The model to use for image generation.<br/>
        /// Default Value: stabilityai/stable-diffusion-xl-base-1.0<br/>
        /// Example: stabilityai/stable-diffusion-xl-base-1.0
        /// </param>
        /// <param name="n">
        /// Number of image results to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="negativePrompt">
        /// The prompt or prompts not to guide the image generation.
        /// </param>
        /// <param name="prompt">
        /// A description of the desired images. Maximum length varies by model.<br/>
        /// Default Value: cat floating in space, cinematic<br/>
        /// Example: cat floating in space, cinematic
        /// </param>
        /// <param name="seed">
        /// Seed used for generation. Can be used to reproduce image generations.
        /// </param>
        /// <param name="steps">
        /// Number of generation steps.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="width">
        /// Width of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ImageResponse> CreateImagesGenerationsAsync(
            string model,
            string prompt,
            int? height = default,
            int? n = default,
            string? negativePrompt = default,
            int? seed = default,
            int? steps = default,
            int? width = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Request2
            {
                Height = height,
                Model = model,
                N = n,
                NegativePrompt = negativePrompt,
                Prompt = prompt,
                Seed = seed,
                Steps = steps,
                Width = width,
            };

            return await CreateImagesGenerationsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}