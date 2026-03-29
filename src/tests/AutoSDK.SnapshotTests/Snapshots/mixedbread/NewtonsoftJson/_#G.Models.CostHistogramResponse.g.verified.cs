//HintName: G.Models.CostHistogramResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostHistogramResponse
    {
        /// <summary>
        /// The histogram of cost information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DailyCostBucket> Data { get; set; } = default!;

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: cost.histogram
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostHistogramResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The histogram of cost information
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: cost.histogram
        /// </param>
        public CostHistogramResponse(
            global::System.Collections.Generic.IList<global::G.DailyCostBucket> data,
            string? @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostHistogramResponse" /> class.
        /// </summary>
        public CostHistogramResponse()
        {
        }
    }
}