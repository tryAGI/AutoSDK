//HintName: G.Models.ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traces", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Traces { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public string Output { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData" /> class.
        /// </summary>
        /// <param name="traces"></param>
        /// <param name="output"></param>
        /// <param name="statusCode"></param>
        public ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData(
            global::System.Collections.Generic.IList<string> traces,
            string output,
            double? statusCode)
        {
            this.StatusCode = statusCode;
            this.Traces = traces ?? throw new global::System.ArgumentNullException(nameof(traces));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData" /> class.
        /// </summary>
        public ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData()
        {
        }
    }
}