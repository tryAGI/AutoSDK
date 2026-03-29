//HintName: G.Models.ErrorCountWithDeviationDetailed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ErrorCountWithDeviationDetailed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviation")]
        public long? Deviation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviation_percentage")]
        public long? DeviationPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorCountWithDeviationDetailed" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="deviation"></param>
        /// <param name="deviationPercentage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorCountWithDeviationDetailed(
            long? count,
            long? deviation,
            long? deviationPercentage)
        {
            this.Count = count;
            this.Deviation = deviation;
            this.DeviationPercentage = deviationPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorCountWithDeviationDetailed" /> class.
        /// </summary>
        public ErrorCountWithDeviationDetailed()
        {
        }
    }
}