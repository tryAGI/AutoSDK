//HintName: G.Models.UserSummaryResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserSummaryResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSummaryResponseDto" /> class.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserSummaryResponseDto(
            string? userName,
            string? firstName,
            string? lastName)
        {
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSummaryResponseDto" /> class.
        /// </summary>
        public UserSummaryResponseDto()
        {
        }
    }
}