//HintName: G.Models.SeverityScoreSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"low":0.5733263024656846,"medium":0.42667369753431533,"high":0}
    /// </summary>
    public sealed partial class SeverityScoreSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Low { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Medium { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double High { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SeverityScoreSummary" /> class.
        /// </summary>
        /// <param name="low"></param>
        /// <param name="medium"></param>
        /// <param name="high"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SeverityScoreSummary(
            double low,
            double medium,
            double high)
        {
            this.Low = low;
            this.Medium = medium;
            this.High = high;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeverityScoreSummary" /> class.
        /// </summary>
        public SeverityScoreSummary()
        {
        }
    }
}