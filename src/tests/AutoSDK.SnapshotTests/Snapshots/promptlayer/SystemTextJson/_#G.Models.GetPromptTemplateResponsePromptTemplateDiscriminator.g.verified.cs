//HintName: G.Models.GetPromptTemplateResponsePromptTemplateDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPromptTemplateResponsePromptTemplateDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeJsonConverter))]
        public global::G.GetPromptTemplateResponsePromptTemplateDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateResponsePromptTemplateDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPromptTemplateResponsePromptTemplateDiscriminator(
            global::G.GetPromptTemplateResponsePromptTemplateDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateResponsePromptTemplateDiscriminator" /> class.
        /// </summary>
        public GetPromptTemplateResponsePromptTemplateDiscriminator()
        {
        }
    }
}