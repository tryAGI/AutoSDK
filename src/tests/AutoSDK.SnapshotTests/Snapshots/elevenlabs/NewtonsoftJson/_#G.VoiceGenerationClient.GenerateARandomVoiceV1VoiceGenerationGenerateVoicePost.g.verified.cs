//HintName: G.VoiceGenerationClient.GenerateARandomVoiceV1VoiceGenerationGenerateVoicePost.g.cs

#nullable enable

namespace G
{
    public partial class VoiceGenerationClient
    {
        partial void PrepareGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xiApiKey,
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost request);
        partial void PrepareGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xiApiKey,
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost request);
        partial void ProcessGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate A Random Voice<br/>
        /// Generate a random voice based on parameters. This method returns a generated_voice_id in the response header, and a sample of the voice in the body. If you like the generated voice call /v1/voice-generation/create-voice with the generated_voice_id to create the voice.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> GenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAsync(
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostArguments(
                httpClient: _httpClient,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/voice-generation/generate-voice",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostRequest(
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
            ProcessGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.HTTPValidationError?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generate A Random Voice<br/>
        /// Generate a random voice based on parameters. This method returns a generated_voice_id in the response header, and a sample of the voice in the body. If you like the generated voice call /v1/voice-generation/create-voice with the generated_voice_id to create the voice.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="gender">
        /// Category code corresponding to the gender of the generated voice. Possible values: female, male.
        /// </param>
        /// <param name="accent">
        /// Category code corresponding to the accent of the generated voice. Possible values: american, british, african, australian, indian.
        /// </param>
        /// <param name="age">
        /// Category code corresponding to the age of the generated voice. Possible values: young, middle_aged, old.
        /// </param>
        /// <param name="accentStrength">
        /// The strength of the accent of the generated voice. Has to be between 0.3 and 2.0.
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> GenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAsync(
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender gender,
            string accent,
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge age,
            double accentStrength,
            string text,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost
            {
                Gender = gender,
                Accent = accent,
                Age = age,
                AccentStrength = accentStrength,
                Text = text,
            };

            return await GenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAsync(
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}