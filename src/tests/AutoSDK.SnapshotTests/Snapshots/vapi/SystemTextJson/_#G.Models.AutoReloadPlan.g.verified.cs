//HintName: G.Models.AutoReloadPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoReloadPlan
    {
        /// <summary>
        /// This the amount of credits to reload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Credits { get; set; }

        /// <summary>
        /// This is the limit at which the reload is triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoReloadPlan" /> class.
        /// </summary>
        /// <param name="credits">
        /// This the amount of credits to reload.
        /// </param>
        /// <param name="threshold">
        /// This is the limit at which the reload is triggered.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoReloadPlan(
            double credits,
            double threshold)
        {
            this.Credits = credits;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoReloadPlan" /> class.
        /// </summary>
        public AutoReloadPlan()
        {
        }
    }
}