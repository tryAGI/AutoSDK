//HintName: G.Models.ClassificationOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output of the classification service<br/>
    /// Example: {"data":[{"index":0,"prediction":"label1","object":"classification","score":0.75},{"index":1,"prediction":"label2","object":"classification","score":0.54}],"usage":{"total_tokens":15,"prompt_tokens":15}}
    /// </summary>
    public sealed partial class ClassificationOutput
    {
        /// <summary>
        /// A list of Classification Objects returned by the classification service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Data { get; set; } = default!;

        /// <summary>
        /// Total usage of the request. Sums up the usage from each individual input
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiSchemasClassificationUsage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationOutput" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of Classification Objects returned by the classification service
        /// </param>
        /// <param name="usage">
        /// Total usage of the request. Sums up the usage from each individual input
        /// </param>
        public ClassificationOutput(
            global::System.Collections.Generic.IList<object> data,
            global::G.ApiSchemasClassificationUsage usage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationOutput" /> class.
        /// </summary>
        public ClassificationOutput()
        {
        }
    }
}