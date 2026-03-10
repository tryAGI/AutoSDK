//HintName: G.Models.ASTLLMNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLLMNodeOutput
    {
        /// <summary>
        /// Default Value: llm
        /// </summary>
        /// <default>"llm"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "llm";

        /// <summary>
        /// The prompt to evaluate to a boolean value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: llm
        /// </param>
        /// <param name="prompt">
        /// The prompt to evaluate to a boolean value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTLLMNodeOutput(
            string prompt,
            string type = "llm")
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeOutput" /> class.
        /// </summary>
        public ASTLLMNodeOutput()
        {
        }
    }
}