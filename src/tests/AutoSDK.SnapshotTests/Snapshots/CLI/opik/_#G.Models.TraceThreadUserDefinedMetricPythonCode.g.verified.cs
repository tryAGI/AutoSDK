//HintName: G.Models.TraceThreadUserDefinedMetricPythonCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceThreadUserDefinedMetricPythonCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadUserDefinedMetricPythonCode" /> class.
        /// </summary>
        /// <param name="metric"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceThreadUserDefinedMetricPythonCode(
            string metric)
        {
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadUserDefinedMetricPythonCode" /> class.
        /// </summary>
        public TraceThreadUserDefinedMetricPythonCode()
        {
        }
    }
}