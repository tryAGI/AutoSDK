//HintName: G.Models.OptimizePromptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to optimize a prompt.
    /// </summary>
    public sealed partial class OptimizePromptRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metaprompt", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metaprompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExampleRunWithFeedback> Examples { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overall_feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public string? OverallFeedback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="metaprompt"></param>
        /// <param name="examples"></param>
        /// <param name="overallFeedback"></param>
        public OptimizePromptRequest(
            string prompt,
            object metaprompt,
            global::System.Collections.Generic.IList<global::G.ExampleRunWithFeedback> examples,
            string? overallFeedback)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Metaprompt = metaprompt ?? throw new global::System.ArgumentNullException(nameof(metaprompt));
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
            this.OverallFeedback = overallFeedback ?? throw new global::System.ArgumentNullException(nameof(overallFeedback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptRequest" /> class.
        /// </summary>
        public OptimizePromptRequest()
        {
        }
    }
}