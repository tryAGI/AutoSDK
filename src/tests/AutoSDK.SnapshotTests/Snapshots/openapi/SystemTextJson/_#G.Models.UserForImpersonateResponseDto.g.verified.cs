//HintName: G.Models.UserForImpersonateResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForImpersonateResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForImpersonateResponseDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForImpersonateResponseDto(
            string userId,
            string username,
            string token)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForImpersonateResponseDto" /> class.
        /// </summary>
        public UserForImpersonateResponseDto()
        {
        }
    }
}