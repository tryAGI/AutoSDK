//HintName: G.Models.UserForProfileUpdateRequiredResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForProfileUpdateRequiredResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileUpdateRequired")]
        public bool? ProfileUpdateRequired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForProfileUpdateRequiredResponseDto" /> class.
        /// </summary>
        /// <param name="profileUpdateRequired"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForProfileUpdateRequiredResponseDto(
            bool? profileUpdateRequired)
        {
            this.ProfileUpdateRequired = profileUpdateRequired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForProfileUpdateRequiredResponseDto" /> class.
        /// </summary>
        public UserForProfileUpdateRequiredResponseDto()
        {
        }
    }
}