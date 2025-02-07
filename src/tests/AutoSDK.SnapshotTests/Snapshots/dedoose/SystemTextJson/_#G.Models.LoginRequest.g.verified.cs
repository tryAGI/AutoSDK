//HintName: G.Models.LoginRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoginRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rsaEncryptedPassword")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RsaEncryptedPassword { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPassword"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoginRequest(
            string username,
            string rsaEncryptedPassword)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.RsaEncryptedPassword = rsaEncryptedPassword ?? throw new global::System.ArgumentNullException(nameof(rsaEncryptedPassword));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginRequest" /> class.
        /// </summary>
        public LoginRequest()
        {
        }
    }
}