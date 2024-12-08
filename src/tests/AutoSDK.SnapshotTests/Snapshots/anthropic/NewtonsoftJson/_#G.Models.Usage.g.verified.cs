//HintName: G.Models.Usage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// The number of input tokens which were used.<br/>
        /// Example: 2095
        /// </summary>
        /// <example>2095</example>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// The number of output tokens which were used.<br/>
        /// Example: 503
        /// </summary>
        /// <example>503</example>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of input tokens which were used.<br/>
        /// Example: 2095
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens which were used.<br/>
        /// Example: 503
        /// </param>
        public Usage(
            int inputTokens,
            int outputTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}