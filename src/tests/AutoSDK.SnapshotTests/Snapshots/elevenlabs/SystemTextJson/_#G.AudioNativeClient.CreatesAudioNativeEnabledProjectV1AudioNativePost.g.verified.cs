//HintName: G.AudioNativeClient.CreatesAudioNativeEnabledProjectV1AudioNativePost.g.cs

#nullable enable

namespace G
{
    public partial class AudioNativeClient
    {
        partial void PrepareCreatesAudioNativeEnabledProjectV1AudioNativePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xiApiKey,
            global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost request);
        partial void PrepareCreatesAudioNativeEnabledProjectV1AudioNativePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xiApiKey,
            global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost request);
        partial void ProcessCreatesAudioNativeEnabledProjectV1AudioNativePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatesAudioNativeEnabledProjectV1AudioNativePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates Audionative Enabled Project.<br/>
        /// Creates AudioNative enabled project, optionally starts conversion and returns project id and embeddable html snippet.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AudioNativeCreateProjectResponseModel> CreatesAudioNativeEnabledProjectV1AudioNativePostAsync(
            global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreatesAudioNativeEnabledProjectV1AudioNativePostArguments(
                httpClient: _httpClient,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/audio-native",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (xiApiKey != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xiApiKey}"),
                    name: "xi-api-key");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Name}"),
                name: "name");
            if (request.Image != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Image}"),
                    name: "image");
            } 
            if (request.Author != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Author}"),
                    name: "author");
            } 
            if (request.Title != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Title}"),
                    name: "title");
            } 
            if (request.Small != false)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Small}"),
                    name: "small");
            } 
            if (request.TextColor != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TextColor}"),
                    name: "text_color");
            } 
            if (request.BackgroundColor != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundColor}"),
                    name: "background_color");
            } 
            if (request.Sessionization != 0)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Sessionization}"),
                    name: "sessionization");
            } 
            if (request.VoiceId != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VoiceId}"),
                    name: "voice_id");
            } 
            if (request.ModelId != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ModelId}"),
                    name: "model_id");
            } 
            if (request.File != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>())
                    {
                        Headers =
                        {
                            ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                        },
                    },
                    name: "file",
                    fileName: request.Filename ?? string.Empty);
            } 
            if (request.AutoConvert != false)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AutoConvert}"),
                    name: "auto_convert");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreatesAudioNativeEnabledProjectV1AudioNativePostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xiApiKey: xiApiKey,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreatesAudioNativeEnabledProjectV1AudioNativePostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreatesAudioNativeEnabledProjectV1AudioNativePostResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.AudioNativeCreateProjectResponseModel?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates Audionative Enabled Project.<br/>
        /// Creates AudioNative enabled project, optionally starts conversion and returns project id and embeddable html snippet.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// Project name.
        /// </param>
        /// <param name="image">
        /// Image URL used in the player. If not provided, default image set in the Player settings is used.
        /// </param>
        /// <param name="author">
        /// Author used in the player and inserted at the start of the uploaded article. If not provided, the default author set in the Player settings is used.
        /// </param>
        /// <param name="title">
        /// Title used in the player and inserted at the top of the uploaded article. If not provided, the default title set in the Player settings is used.
        /// </param>
        /// <param name="small">
        /// Whether to use small player or not. If not provided, default value set in the Player settings is used.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="textColor">
        /// Text color used in the player. If not provided, default text color set in the Player settings is used.
        /// </param>
        /// <param name="backgroundColor">
        /// Background color used in the player. If not provided, default background color set in the Player settings is used.
        /// </param>
        /// <param name="sessionization">
        /// Specifies for how many minutes to persist the session across page reloads. If not provided, default sessionization set in the Player settings is used.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="voiceId">
        /// Voice ID used to voice the content. If not provided, default voice ID set in the Player settings is used.
        /// </param>
        /// <param name="modelId">
        /// TTS Model ID used in the player. If not provided, default model ID set in the Player settings is used.
        /// </param>
        /// <param name="file">
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h5&amp;gt;More of your content&amp;lt;/h5&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </param>
        /// <param name="filename">
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h5&amp;gt;More of your content&amp;lt;/h5&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </param>
        /// <param name="autoConvert">
        /// Whether to auto convert the project to audio or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AudioNativeCreateProjectResponseModel> CreatesAudioNativeEnabledProjectV1AudioNativePostAsync(
            string name,
            string? xiApiKey = default,
            string? image = default,
            string? author = default,
            string? title = default,
            bool? small = false,
            string? textColor = default,
            string? backgroundColor = default,
            int? sessionization = 0,
            string? voiceId = default,
            string? modelId = default,
            byte[]? file = default,
            string? filename = default,
            bool? autoConvert = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost
            {
                Name = name,
                Image = image,
                Author = author,
                Title = title,
                Small = small,
                TextColor = textColor,
                BackgroundColor = backgroundColor,
                Sessionization = sessionization,
                VoiceId = voiceId,
                ModelId = modelId,
                File = file,
                Filename = filename,
                AutoConvert = autoConvert,
            };

            return await CreatesAudioNativeEnabledProjectV1AudioNativePostAsync(
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}