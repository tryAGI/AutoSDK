//HintName: G.Models.ValidateUser2Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidateUser2Request
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
        [global::System.Text.Json.Serialization.JsonPropertyName("rsaEncryptedPass")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RsaEncryptedPass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ConnectionKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUser2Request" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPass"></param>
        /// <param name="connectionKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ValidateUser2Request(
            string username,
            string rsaEncryptedPass,
            global::System.Guid connectionKey)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.RsaEncryptedPass = rsaEncryptedPass ?? throw new global::System.ArgumentNullException(nameof(rsaEncryptedPass));
            this.ConnectionKey = connectionKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUser2Request" /> class.
        /// </summary>
        public ValidateUser2Request()
        {
        }
    }
}