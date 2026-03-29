//HintName: G.Models.ResultSuccessCountNumberData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessCountNumberData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessCountNumberData" /> class.
        /// </summary>
        /// <param name="count"></param>
        public ResultSuccessCountNumberData(
            double count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessCountNumberData" /> class.
        /// </summary>
        public ResultSuccessCountNumberData()
        {
        }
    }
}