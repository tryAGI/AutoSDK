//HintName: G.Models.Prompt2025VersionPromptBodyTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025VersionPromptBodyTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Prompt2025VersionPromptBodyToolFunction Function { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.Prompt2025VersionPromptBodyToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyTool" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
        public Prompt2025VersionPromptBodyTool(
            global::G.Prompt2025VersionPromptBodyToolFunction function,
            global::G.Prompt2025VersionPromptBodyToolType type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyTool" /> class.
        /// </summary>
        public Prompt2025VersionPromptBodyTool()
        {
        }
    }
}