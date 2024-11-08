//HintName: G.VoicesClient.CreateVoicesAddByPublicUserIdByVoiceId.g.cs

#nullable enable

namespace G
{
    public partial class VoicesClient
    {
        partial void PrepareCreateVoicesAddByPublicUserIdByVoiceIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string publicUserId,
            ref string voiceId,
            ref string? xiApiKey,
            global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost request);
        partial void PrepareCreateVoicesAddByPublicUserIdByVoiceIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string publicUserId,
            string voiceId,
            string? xiApiKey,
            global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost request);
        partial void ProcessCreateVoicesAddByPublicUserIdByVoiceIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVoicesAddByPublicUserIdByVoiceIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add Sharing Voice<br/>
        /// Add a sharing voice to your collection of voices in VoiceLab.
        /// </summary>
        /// <param name="publicUserId">
        /// Public user ID used to publicly identify ElevenLabs users.
        /// </param>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesAddByPublicUserIdByVoiceIdAsync(
            string publicUserId,
            string voiceId,
            global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVoicesAddByPublicUserIdByVoiceIdArguments(
                httpClient: HttpClient,
                publicUserId: ref publicUserId,
                voiceId: ref voiceId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/voices/add/{publicUserId}/{voiceId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
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
            PrepareCreateVoicesAddByPublicUserIdByVoiceIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                publicUserId: publicUserId,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateVoicesAddByPublicUserIdByVoiceIdResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateVoicesAddByPublicUserIdByVoiceIdResponseContent(
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
                    global::G.AddVoiceResponseModel.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = await global::G.AddVoiceResponseModel.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Add Sharing Voice<br/>
        /// Add a sharing voice to your collection of voices in VoiceLab.
        /// </summary>
        /// <param name="publicUserId">
        /// Public user ID used to publicly identify ElevenLabs users.
        /// </param>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="newName">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesAddByPublicUserIdByVoiceIdAsync(
            string publicUserId,
            string voiceId,
            string newName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost
            {
                NewName = newName,
            };

            return await CreateVoicesAddByPublicUserIdByVoiceIdAsync(
                publicUserId: publicUserId,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}