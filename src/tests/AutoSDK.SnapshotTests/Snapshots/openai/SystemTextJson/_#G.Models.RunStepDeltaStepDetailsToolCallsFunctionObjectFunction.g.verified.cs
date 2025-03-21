//HintName: G.Models.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of the function that was called.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsFunctionObjectFunction
    {
        /// <summary>
        /// The arguments passed to the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsFunctionObjectFunction" /> class.
        /// </summary>
        /// <param name="arguments">
        /// The arguments passed to the function.
        /// </param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="output">
        /// The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaStepDetailsToolCallsFunctionObjectFunction(
            string? arguments,
            string? name,
            string? output)
        {
            this.Arguments = arguments;
            this.Name = name;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsFunctionObjectFunction" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsFunctionObjectFunction()
        {
        }
    }
}