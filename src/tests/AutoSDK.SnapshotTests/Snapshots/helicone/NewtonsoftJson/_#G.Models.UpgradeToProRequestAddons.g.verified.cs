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
        [global::Newtonsoft.Json.JsonProperty("evals")]
        public bool? Evals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiments")]
        public bool? Experiments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts")]
        public bool? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alerts")]
        public bool? Alerts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeToProRequestAddons" /> class.
        /// </summary>
        /// <param name="evals"></param>
        /// <param name="experiments"></param>
        /// <param name="prompts"></param>
        /// <param name="alerts"></param>
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