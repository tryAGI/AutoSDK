//HintName: G.Models.UserForResetPasswordRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForResetPasswordRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentPassword")]
        public string? CurrentPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmPassword")]
        public string? ConfirmPassword { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForResetPasswordRequestDto" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="currentPassword"></param>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForResetPasswordRequestDto(
            string? code,
            string? currentPassword,
            long? id,
            string? username,
            string? password,
            string? confirmPassword)
        {
            this.Code = code;
            this.CurrentPassword = currentPassword;
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForResetPasswordRequestDto" /> class.
        /// </summary>
        public UserForResetPasswordRequestDto()
        {
        }
    }
}