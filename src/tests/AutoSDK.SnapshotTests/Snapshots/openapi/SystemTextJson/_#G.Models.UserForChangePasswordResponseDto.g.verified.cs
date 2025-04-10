//HintName: G.Models.UserForChangePasswordResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForChangePasswordResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed")]
        public bool? Changed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForChangePasswordResponseDto" /> class.
        /// </summary>
        /// <param name="changed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForChangePasswordResponseDto(
            bool? changed)
        {
            this.Changed = changed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForChangePasswordResponseDto" /> class.
        /// </summary>
        public UserForChangePasswordResponseDto()
        {
        }
    }
}