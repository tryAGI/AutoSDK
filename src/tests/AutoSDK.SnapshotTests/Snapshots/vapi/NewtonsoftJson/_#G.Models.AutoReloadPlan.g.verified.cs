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
        [global::Newtonsoft.Json.JsonProperty("credits", Required = global::Newtonsoft.Json.Required.Always)]
        public double Credits { get; set; } = default!;

        /// <summary>
        /// This is the limit at which the reload is triggered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public double Threshold { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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