//HintName: G.ITokenClient.CreateToken.g.cs
#nullable enable

namespace G
{
    public partial interface ITokenClient
    {
        /// <summary>
        /// Create an API token<br/>
        /// Creates an API token for the authenticated user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTokenResponse> CreateTokenAsync(
            global::G.ApiToken request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        /// State.
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
        global::System.Threading.Tasks.Task<global::G.CreateTokenResponse> CreateTokenAsync(
            global::System.DateTime? lastUseTime = default,
            string? name = default,
            string? uid = default,
            string? id = default,
            global::System.DateTime? createTime = default,
            global::System.DateTime? updateTime = default,
            string? accessToken = default,
            global::G.AllOf<global::G.ApiTokenState?>? state = default,
            string? tokenType = default,
            int? ttl = default,
            global::System.DateTime? expireTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}