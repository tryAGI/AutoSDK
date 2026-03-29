//HintName: G.Models.TestInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTemplate")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestInputInputs Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputBody")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputBody")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInput" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="outputBody"></param>
        /// <param name="inputBody"></param>
        /// <param name="promptTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestInput(
            global::G.TestInputInputs inputs,
            string outputBody,
            string inputBody,
            string? promptTemplate)
        {
            this.PromptTemplate = promptTemplate;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.OutputBody = outputBody ?? throw new global::System.ArgumentNullException(nameof(outputBody));
            this.InputBody = inputBody ?? throw new global::System.ArgumentNullException(nameof(inputBody));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInput" /> class.
        /// </summary>
        public TestInput()
        {
        }
    }
}