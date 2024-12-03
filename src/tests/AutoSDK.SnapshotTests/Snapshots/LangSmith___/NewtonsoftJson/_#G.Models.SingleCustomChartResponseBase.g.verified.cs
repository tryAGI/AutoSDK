//HintName: G.Models.SingleCustomChartResponseBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleCustomChartResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomChartsDataPoint> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartResponseBase" /> class.
        /// </summary>
        /// <param name="data"></param>
        public SingleCustomChartResponseBase(
            global::System.Collections.Generic.IList<global::G.CustomChartsDataPoint> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartResponseBase" /> class.
        /// </summary>
        public SingleCustomChartResponseBase()
        {
        }
    }
}