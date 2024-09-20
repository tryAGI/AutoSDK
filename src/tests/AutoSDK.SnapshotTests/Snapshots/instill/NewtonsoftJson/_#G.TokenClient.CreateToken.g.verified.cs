//HintName: G.TokenClient.CreateToken.g.cs

#nullable enable

namespace G
{
    public partial class TokenClient
    {
        partial void PrepareCreateTokenArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ApiToken request);
        partial void PrepareCreateTokenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ApiToken request);
        partial void ProcessCreateTokenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTokenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an API token<br/>
        /// Creates an API token for the authenticated user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateTokenResponse> CreateTokenAsync(
            global::G.ApiToken request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateTokenArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1beta/tokens",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateTokenRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateTokenResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateTokenResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateTokenResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an API token<br/>
        /// Creates an API token for the authenticated user.
        /// </summary>
        /// <param name="lastUseTime">
        /// When users trigger a pipeline which uses an API token, the token is<br/>
        /// updated with the current time. This field is used to track the last time<br/>
        /// the token was used.
        /// </param>
        /// <param name="name">
        /// The name of the token, define by its ID.<br/>
        /// - Format: `tokens/{token.id}`.
        /// </param>
        /// <param name="uid">
        /// API token UUID.
        /// </param>
        /// <param name="id">
        /// API token resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.<br/>
        /// This field can reflect the client(s) that will use the token.
        /// </param>
        /// <param name="createTime">
        /// Creation time.
        /// </param>
        /// <param name="updateTime">
        /// Update time.
        /// </param>
        /// <param name="accessToken">
        /// An opaque access token representing the API token string.<br/>
        /// To validate the token, the recipient of the token needs to call the server<br/>
        /// that issued the token.
        /// </param>
        /// <param name="state">
        /// State describes the state of an API token.<br/>
        ///  - STATE_INACTIVE: Inactive.<br/>
        ///  - STATE_ACTIVE: Active.<br/>
        ///  - STATE_EXPIRED: Expired.
        /// </param>
        /// <param name="tokenType">
        /// Token type. Value is fixed to "Bearer".
        /// </param>
        /// <param name="ttl">
        /// The time-to-live in seconds for this resource.
        /// </param>
        /// <param name="expireTime">
        /// Expiration time.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateTokenResponse> CreateTokenAsync(
            global::System.DateTime? lastUseTime = default,
            string? name = default,
            string? uid = default,
            string? id = default,
            global::System.DateTime? createTime = default,
            global::System.DateTime? updateTime = default,
            string? accessToken = default,
            global::G.ApiTokenState? state = default,
            string? tokenType = default,
            int? ttl = default,
            global::System.DateTime? expireTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ApiToken
            {
                LastUseTime = lastUseTime,
                Name = name,
                Uid = uid,
                Id = id,
                CreateTime = createTime,
                UpdateTime = updateTime,
                AccessToken = accessToken,
                State = state,
                TokenType = tokenType,
                Ttl = ttl,
                ExpireTime = expireTime,
            };

            return await CreateTokenAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}