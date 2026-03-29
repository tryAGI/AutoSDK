//HintName: G.Models.Quantiles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Quantiles
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p75")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P75 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P90 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P95 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantiles" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="p75"></param>
        /// <param name="p90"></param>
        /// <param name="p95"></param>
        /// <param name="p99"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Quantiles(
            global::System.DateTime time,
            double p75,
            double p90,
            double p95,
            double p99)
        {
            this.Time = time;
            this.P75 = p75;
            this.P90 = p90;
            this.P95 = p95;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantiles" /> class.
        /// </summary>
        public Quantiles()
        {
        }
    }
}