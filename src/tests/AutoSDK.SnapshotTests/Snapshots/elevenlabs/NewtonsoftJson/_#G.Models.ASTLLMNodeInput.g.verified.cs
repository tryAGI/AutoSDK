//HintName: G.Models.ASTLLMNodeInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLLMNodeInput
    {
        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The prompt to evaluate to a boolean value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeInput" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to evaluate to a boolean value.
        /// </param>
        /// <param name="type">
        /// Default Value: llm
        /// </param>
        public ASTLLMNodeInput(
            string prompt,
            string? type)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeInput" /> class.
        /// </summary>
        public ASTLLMNodeInput()
        {
        }
    }
}