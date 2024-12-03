//HintName: G.Models.ExampleRunWithFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An example run with feedback.
    /// </summary>
    public sealed partial class ExampleRunWithFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleRunWithFeedback" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="referenceOutput"></param>
        /// <param name="output"></param>
        /// <param name="feedback"></param>
        /// <param name="runId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ExampleRunWithFeedback(
            string input,
            string referenceOutput,
            string output,
            string feedback,
            string runId)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ReferenceOutput = referenceOutput ?? throw new global::System.ArgumentNullException(nameof(referenceOutput));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleRunWithFeedback" /> class.
        /// </summary>
        public ExampleRunWithFeedback()
        {
        }
    }
}