//HintName: G.Models.GetPromptTemplateRawResponsePromptTemplateDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPromptTemplateRawResponsePromptTemplateDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeJsonConverter))]
        public global::G.GetPromptTemplateRawResponsePromptTemplateDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateRawResponsePromptTemplateDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPromptTemplateRawResponsePromptTemplateDiscriminator(
            global::G.GetPromptTemplateRawResponsePromptTemplateDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateRawResponsePromptTemplateDiscriminator" /> class.
        /// </summary>
        public GetPromptTemplateRawResponsePromptTemplateDiscriminator()
        {
        }
    }
}