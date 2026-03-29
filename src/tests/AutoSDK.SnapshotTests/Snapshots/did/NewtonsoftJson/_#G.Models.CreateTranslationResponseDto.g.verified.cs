//HintName: G.Models.CreateTranslationResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslationResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateTranslationResponseDtoTranslation> Translations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationResponseDto" /> class.
        /// </summary>
        /// <param name="translations"></param>
        public CreateTranslationResponseDto(
            global::System.Collections.Generic.IList<global::G.CreateTranslationResponseDtoTranslation> translations)
        {
            this.Translations = translations ?? throw new global::System.ArgumentNullException(nameof(translations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationResponseDto" /> class.
        /// </summary>
        public CreateTranslationResponseDto()
        {
        }
    }
}