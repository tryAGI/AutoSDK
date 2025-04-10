//HintName: G.Models.UserForUpdateLanguageRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForUpdateLanguageRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForUpdateLanguageRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="language"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForUpdateLanguageRequestDto(
            long? id,
            string? language)
        {
            this.Id = id;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForUpdateLanguageRequestDto" /> class.
        /// </summary>
        public UserForUpdateLanguageRequestDto()
        {
        }
    }
}