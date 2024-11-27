//HintName: G.Models.Validate2FactorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Validate2FactorRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ConnectionKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedAuthToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedAuthToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Validate2FactorRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="connectionKey"></param>
        /// <param name="encryptedAuthToken"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Validate2FactorRequest(
            string username,
            global::System.Guid connectionKey,
            string encryptedAuthToken)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.ConnectionKey = connectionKey;
            this.EncryptedAuthToken = encryptedAuthToken ?? throw new global::System.ArgumentNullException(nameof(encryptedAuthToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Validate2FactorRequest" /> class.
        /// </summary>
        public Validate2FactorRequest()
        {
        }
    }
}