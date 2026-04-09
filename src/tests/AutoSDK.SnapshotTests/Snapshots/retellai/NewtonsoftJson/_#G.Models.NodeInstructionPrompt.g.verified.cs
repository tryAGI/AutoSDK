//HintName: G.Models.NodeInstructionPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeInstructionPrompt
    {
        /// <summary>
        /// Type of instruction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.NodeInstructionPromptTypeJsonConverter))]
        public global::G.NodeInstructionPromptType Type { get; set; }

        /// <summary>
        /// The prompt text for the instruction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInstructionPrompt" /> class.
        /// </summary>
        /// <param name="text">
        /// The prompt text for the instruction
        /// </param>
        /// <param name="type">
        /// Type of instruction
        /// </param>
        public NodeInstructionPrompt(
            string text,
            global::G.NodeInstructionPromptType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInstructionPrompt" /> class.
        /// </summary>
        public NodeInstructionPrompt()
        {
        }
    }
}