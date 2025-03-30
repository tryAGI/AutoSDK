//HintName: G.Models.MetricRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("elapsed_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double ElapsedTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricRecord" /> class.
        /// </summary>
        /// <param name="elapsedTime"></param>
        public MetricRecord(
            double elapsedTime)
        {
            this.ElapsedTime = elapsedTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricRecord" /> class.
        /// </summary>
        public MetricRecord()
        {
        }
    }
}