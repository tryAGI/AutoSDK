//HintName: G.Models.UserForLoginResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForLoginResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetLinkSent")]
        public bool? ResetLinkSent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFirstTimeLogin")]
        public bool? IsFirstTimeLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastLoginDate")]
        public global::System.DateTime? LastLoginDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForLoginResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="token"></param>
        /// <param name="resetLinkSent"></param>
        /// <param name="isFirstTimeLogin"></param>
        /// <param name="lastLoginDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForLoginResponseDto(
            string? id,
            string? username,
            string? token,
            bool? resetLinkSent,
            bool? isFirstTimeLogin,
            global::System.DateTime? lastLoginDate)
        {
            this.Id = id;
            this.Username = username;
            this.Token = token;
            this.ResetLinkSent = resetLinkSent;
            this.IsFirstTimeLogin = isFirstTimeLogin;
            this.LastLoginDate = lastLoginDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForLoginResponseDto" /> class.
        /// </summary>
        public UserForLoginResponseDto()
        {
        }
    }
}