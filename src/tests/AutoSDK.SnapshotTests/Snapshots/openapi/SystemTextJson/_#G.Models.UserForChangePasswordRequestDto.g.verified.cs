//HintName: G.Models.UserForChangePasswordRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForChangePasswordRequestDto
    {
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
        /// Initializes a new instance of the <see cref="UserForChangePasswordRequestDto" /> class.
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForChangePasswordRequestDto(
            string? currentPassword,
            long? id,
            string? password,
            string? confirmPassword)
        {
            this.CurrentPassword = currentPassword;
            this.Id = id;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForChangePasswordRequestDto" /> class.
        /// </summary>
        public UserForChangePasswordRequestDto()
        {
        }
    }
}