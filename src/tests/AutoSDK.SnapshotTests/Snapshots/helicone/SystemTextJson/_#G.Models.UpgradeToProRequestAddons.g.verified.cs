//HintName: G.Models.UpgradeToProRequestAddons.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpgradeToProRequestAddons
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evals")]
        public bool? Evals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiments")]
        public bool? Experiments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public bool? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alerts")]
        public bool? Alerts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeToProRequestAddons" /> class.
        /// </summary>
        /// <param name="evals"></param>
        /// <param name="experiments"></param>
        /// <param name="prompts"></param>
        /// <param name="alerts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpgradeToProRequestAddons(
            bool? evals,
            bool? experiments,
            bool? prompts,
            bool? alerts)
        {
            this.Evals = evals;
            this.Experiments = experiments;
            this.Prompts = prompts;
            this.Alerts = alerts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeToProRequestAddons" /> class.
        /// </summary>
        public UpgradeToProRequestAddons()
        {
        }
    }
}