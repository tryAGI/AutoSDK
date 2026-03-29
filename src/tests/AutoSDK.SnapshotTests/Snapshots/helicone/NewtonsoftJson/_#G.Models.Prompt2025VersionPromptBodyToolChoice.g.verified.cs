//HintName: G.Models.Prompt2025VersionPromptBodyToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025VersionPromptBodyToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.Prompt2025VersionPromptBodyToolChoiceFunction? Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyToolChoice" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="function"></param>
        public Prompt2025VersionPromptBodyToolChoice(
            string type,
            global::G.Prompt2025VersionPromptBodyToolChoiceFunction? function)
        {
            this.Function = function;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyToolChoice" /> class.
        /// </summary>
        public Prompt2025VersionPromptBodyToolChoice()
        {
        }
    }
}