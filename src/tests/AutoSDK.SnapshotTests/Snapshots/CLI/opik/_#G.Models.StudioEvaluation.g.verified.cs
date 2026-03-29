//HintName: G.Models.StudioEvaluation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioEvaluation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StudioMetric> Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioEvaluation" /> class.
        /// </summary>
        /// <param name="metrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StudioEvaluation(
            global::System.Collections.Generic.IList<global::G.StudioMetric> metrics)
        {
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioEvaluation" /> class.
        /// </summary>
        public StudioEvaluation()
        {
        }
    }
}