//HintName: G.Models.PromptBlueprintPromptTemplateDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptBlueprintPromptTemplateDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptBlueprintPromptTemplateDiscriminatorTypeJsonConverter))]
        public global::G.PromptBlueprintPromptTemplateDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlueprintPromptTemplateDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PromptBlueprintPromptTemplateDiscriminator(
            global::G.PromptBlueprintPromptTemplateDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlueprintPromptTemplateDiscriminator" /> class.
        /// </summary>
        public PromptBlueprintPromptTemplateDiscriminator()
        {
        }
    }
}