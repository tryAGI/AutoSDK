//HintName: G.Models.ModelMetricsBodyTimeFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelMetricsBodyTimeFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Start { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMetricsBodyTimeFilter" /> class.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="start"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelMetricsBodyTimeFilter(
            string end,
            string start)
        {
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMetricsBodyTimeFilter" /> class.
        /// </summary>
        public ModelMetricsBodyTimeFilter()
        {
        }
    }
}