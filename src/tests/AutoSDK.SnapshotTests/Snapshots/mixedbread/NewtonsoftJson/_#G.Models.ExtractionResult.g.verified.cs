//HintName: G.Models.ExtractionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of an extraction job.
    /// </summary>
    public sealed partial class ExtractionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public object Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warnings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Warnings { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionResult" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="warnings"></param>
        public ExtractionResult(
            object data,
            global::System.Collections.Generic.IList<string> warnings)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Warnings = warnings ?? throw new global::System.ArgumentNullException(nameof(warnings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionResult" /> class.
        /// </summary>
        public ExtractionResult()
        {
        }
    }
}