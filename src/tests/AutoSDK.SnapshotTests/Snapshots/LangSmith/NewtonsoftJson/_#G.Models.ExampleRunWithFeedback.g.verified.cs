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
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_output", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceOutput { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public string Output { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public string Feedback { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleRunWithFeedback" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="referenceOutput"></param>
        /// <param name="output"></param>
        /// <param name="feedback"></param>
        /// <param name="runId"></param>
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