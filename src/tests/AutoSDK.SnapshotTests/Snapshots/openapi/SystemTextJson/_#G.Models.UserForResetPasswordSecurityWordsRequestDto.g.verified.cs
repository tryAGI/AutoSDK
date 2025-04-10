//HintName: G.Models.UserForResetPasswordSecurityWordsRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForResetPasswordSecurityWordsRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityWords")]
        public string? SecurityWords { get; set; }

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
        /// Initializes a new instance of the <see cref="UserForResetPasswordSecurityWordsRequestDto" /> class.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="securityWords"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForResetPasswordSecurityWordsRequestDto(
            string? userName,
            string? securityWords,
            string? password,
            string? confirmPassword)
        {
            this.UserName = userName;
            this.SecurityWords = securityWords;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForResetPasswordSecurityWordsRequestDto" /> class.
        /// </summary>
        public UserForResetPasswordSecurityWordsRequestDto()
        {
        }
    }
}