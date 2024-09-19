//HintName: G.ExtensionsClient.SetExtensionRequiredConfiguration.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        partial void PrepareSetExtensionRequiredConfigurationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::G.SetExtensionRequiredConfigurationBody request);
        partial void PrepareSetExtensionRequiredConfigurationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::G.SetExtensionRequiredConfigurationBody request);
        partial void ProcessSetExtensionRequiredConfigurationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Updates the extension’s required_configuration string.<br/>
        /// Updates the extension’s required\_configuration string. Use this endpoint if your extension requires the broadcaster to configure the extension before activating it (to require configuration, you must select **Custom/My Own Service** in Extension [Capabilities](https://dev.twitch.tv/docs/extensions/life-cycle/#capabilities)). For more information, see [Required Configurations](https://dev.twitch.tv/docs/extensions/building#required-configurations) and [Setting Required Configuration](https://dev.twitch.tv/docs/extensions/building#setting-required-configuration-with-the-configuration-service-optional).<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an EBS. For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). Set the `role` field to _external_ and the `user_id` field to the ID of the user that owns the extension.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SetExtensionRequiredConfigurationAsync(
            string broadcasterId,
            global::G.SetExtensionRequiredConfigurationBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSetExtensionRequiredConfigurationArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/extensions/required_configuration",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSetExtensionRequiredConfigurationRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSetExtensionRequiredConfigurationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Updates the extension’s required_configuration string.<br/>
        /// Updates the extension’s required\_configuration string. Use this endpoint if your extension requires the broadcaster to configure the extension before activating it (to require configuration, you must select **Custom/My Own Service** in Extension [Capabilities](https://dev.twitch.tv/docs/extensions/life-cycle/#capabilities)). For more information, see [Required Configurations](https://dev.twitch.tv/docs/extensions/building#required-configurations) and [Setting Required Configuration](https://dev.twitch.tv/docs/extensions/building#setting-required-configuration-with-the-configuration-service-optional).<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an EBS. For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). Set the `role` field to _external_ and the `user_id` field to the ID of the user that owns the extension.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="extensionId">
        /// The ID of the extension to update.
        /// </param>
        /// <param name="extensionVersion">
        /// The version of the extension to update.
        /// </param>
        /// <param name="requiredConfiguration">
        /// The required\_configuration string to use with the extension.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SetExtensionRequiredConfigurationAsync(
            string broadcasterId,
            string extensionId,
            string extensionVersion,
            string requiredConfiguration,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.SetExtensionRequiredConfigurationBody
            {
                ExtensionId = extensionId,
                ExtensionVersion = extensionVersion,
                RequiredConfiguration = requiredConfiguration,
            };

            await SetExtensionRequiredConfigurationAsync(
                broadcasterId: broadcasterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}