//HintName: G.Models.TestInstructionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing the rendered instruction.
    /// </summary>
    public sealed partial class TestInstructionResponse
    {
        /// <summary>
        /// The instruction template rendered with the provided context.<br/>
        /// Example: You are a helpful customer support agent for Acme Corp. Today's date is 2024-01-15. You have access to the following tools: Web Search, Email Sender
        /// </summary>
        /// <example>You are a helpful customer support agent for Acme Corp. Today's date is 2024-01-15. You have access to the following tools: Web Search, Email Sender</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RenderedInstruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInstructionResponse" /> class.
        /// </summary>
        /// <param name="renderedInstruction">
        /// The instruction template rendered with the provided context.<br/>
        /// Example: You are a helpful customer support agent for Acme Corp. Today's date is 2024-01-15. You have access to the following tools: Web Search, Email Sender
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestInstructionResponse(
            string renderedInstruction)
        {
            this.RenderedInstruction = renderedInstruction ?? throw new global::System.ArgumentNullException(nameof(renderedInstruction));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInstructionResponse" /> class.
        /// </summary>
        public TestInstructionResponse()
        {
        }
    }
}