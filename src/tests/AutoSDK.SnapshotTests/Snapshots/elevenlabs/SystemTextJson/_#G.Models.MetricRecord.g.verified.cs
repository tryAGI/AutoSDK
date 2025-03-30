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
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ElapsedTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricRecord" /> class.
        /// </summary>
        /// <param name="elapsedTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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