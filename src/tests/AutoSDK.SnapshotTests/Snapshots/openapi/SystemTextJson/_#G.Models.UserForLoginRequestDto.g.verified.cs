//HintName: G.Models.UserForLoginRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForLoginRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForLoginRequestDto" /> class.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForLoginRequestDto(
            string? userName,
            string? password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForLoginRequestDto" /> class.
        /// </summary>
        public UserForLoginRequestDto()
        {
        }
    }
}