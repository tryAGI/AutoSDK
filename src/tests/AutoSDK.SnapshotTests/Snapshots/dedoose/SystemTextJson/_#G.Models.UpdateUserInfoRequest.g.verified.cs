//HintName: G.Models.UpdateUserInfoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUserInfoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserInfoRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUserInfoRequest(
            global::System.Guid userId,
            string username,
            string email,
            string phone)
        {
            this.UserId = userId;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Phone = phone ?? throw new global::System.ArgumentNullException(nameof(phone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserInfoRequest" /> class.
        /// </summary>
        public UpdateUserInfoRequest()
        {
        }
    }
}