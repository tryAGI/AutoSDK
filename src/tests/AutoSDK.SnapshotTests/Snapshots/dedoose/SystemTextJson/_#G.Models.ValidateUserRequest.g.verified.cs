//HintName: G.Models.ValidateUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidateUserRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("passSalt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PassSalt { get; set; }

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
        /// Initializes a new instance of the <see cref="ValidateUserRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="passSalt"></param>
        /// <param name="connectionKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidateUserRequest(
            string username,
            string passSalt,
            global::System.Guid connectionKey)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.PassSalt = passSalt ?? throw new global::System.ArgumentNullException(nameof(passSalt));
            this.ConnectionKey = connectionKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUserRequest" /> class.
        /// </summary>
        public ValidateUserRequest()
        {
        }
    }
}