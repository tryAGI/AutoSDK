//HintName: G.Models.PromptToolsToolChoiceDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptToolsToolChoiceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeJsonConverter))]
        public global::G.PromptToolsToolChoiceDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolsToolChoiceDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PromptToolsToolChoiceDiscriminator(
            global::G.PromptToolsToolChoiceDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolsToolChoiceDiscriminator" /> class.
        /// </summary>
        public PromptToolsToolChoiceDiscriminator()
        {
        }
    }
}