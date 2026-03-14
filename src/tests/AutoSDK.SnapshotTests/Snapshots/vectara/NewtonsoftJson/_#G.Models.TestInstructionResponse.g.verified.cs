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
        [global::Newtonsoft.Json.JsonProperty("rendered_instruction", Required = global::Newtonsoft.Json.Required.Always)]
        public string RenderedInstruction { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInstructionResponse" /> class.
        /// </summary>
        /// <param name="renderedInstruction">
        /// The instruction template rendered with the provided context.<br/>
        /// Example: You are a helpful customer support agent for Acme Corp. Today's date is 2024-01-15. You have access to the following tools: Web Search, Email Sender
        /// </param>
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