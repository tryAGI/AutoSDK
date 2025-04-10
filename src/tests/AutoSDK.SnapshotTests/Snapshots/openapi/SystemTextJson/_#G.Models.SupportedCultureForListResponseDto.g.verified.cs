//HintName: G.Models.SupportedCultureForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SupportedCultureForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cutlureName")]
        public string? CutlureName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customName")]
        public string? CustomName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nativeName")]
        public string? NativeName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedCultureForListResponseDto" /> class.
        /// </summary>
        /// <param name="cutlureName"></param>
        /// <param name="customName"></param>
        /// <param name="displayName"></param>
        /// <param name="nativeName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupportedCultureForListResponseDto(
            string? cutlureName,
            string? customName,
            string? displayName,
            string? nativeName)
        {
            this.CutlureName = cutlureName;
            this.CustomName = customName;
            this.DisplayName = displayName;
            this.NativeName = nativeName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedCultureForListResponseDto" /> class.
        /// </summary>
        public SupportedCultureForListResponseDto()
        {
        }
    }
}