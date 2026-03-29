//HintName: G.Models.TraceWithDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceWithDetails
    {
        /// <summary>
        /// Path of trace in Langfuse UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("htmlPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlPath { get; set; }

        /// <summary>
        /// Latency of trace in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Cost of trace in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// List of observation ids
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observations")]
        public global::System.Collections.Generic.IList<string>? Observations { get; set; }

        /// <summary>
        /// List of score ids
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.IList<string>? Scores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWithDetails" /> class.
        /// </summary>
        /// <param name="htmlPath">
        /// Path of trace in Langfuse UI
        /// </param>
        /// <param name="latency">
        /// Latency of trace in seconds
        /// </param>
        /// <param name="totalCost">
        /// Cost of trace in USD
        /// </param>
        /// <param name="observations">
        /// List of observation ids
        /// </param>
        /// <param name="scores">
        /// List of score ids
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceWithDetails(
            string htmlPath,
            double? latency,
            double? totalCost,
            global::System.Collections.Generic.IList<string>? observations,
            global::System.Collections.Generic.IList<string>? scores)
        {
            this.HtmlPath = htmlPath ?? throw new global::System.ArgumentNullException(nameof(htmlPath));
            this.Latency = latency;
            this.TotalCost = totalCost;
            this.Observations = observations;
            this.Scores = scores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWithDetails" /> class.
        /// </summary>
        public TraceWithDetails()
        {
        }
    }
}