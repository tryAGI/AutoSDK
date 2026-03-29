//HintName: G.Models.AuthTokenResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthTokenResponse
    {
        /// <summary>
        /// The timestamp at which the generated token will expire - in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiryInEpochMillis")]
        public long? ExpiryInEpochMillis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenResponse" /> class.
        /// </summary>
        /// <param name="expiryInEpochMillis">
        /// The timestamp at which the generated token will expire - in Unix time.
        /// </param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthTokenResponse(
            long? expiryInEpochMillis,
            string? token)
        {
            this.ExpiryInEpochMillis = expiryInEpochMillis;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenResponse" /> class.
        /// </summary>
        public AuthTokenResponse()
        {
        }
    }
}