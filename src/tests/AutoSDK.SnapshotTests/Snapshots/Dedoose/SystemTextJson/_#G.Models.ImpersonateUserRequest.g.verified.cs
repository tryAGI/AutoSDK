//HintName: G.Models.ImpersonateUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImpersonateUserRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImpersonateUserRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImpersonateUserRequest(
            string username,
            string email)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImpersonateUserRequest" /> class.
        /// </summary>
        public ImpersonateUserRequest()
        {
        }
    }
}