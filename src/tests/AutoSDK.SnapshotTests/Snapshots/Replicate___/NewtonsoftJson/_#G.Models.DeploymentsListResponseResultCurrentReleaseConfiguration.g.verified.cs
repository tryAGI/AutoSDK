//HintName: G.Models.DeploymentsListResponseResultCurrentReleaseConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsListResponseResultCurrentReleaseConfiguration
    {
        /// <summary>
        /// The SKU for the hardware used to run the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hardware")]
        public string? Hardware { get; set; }

        /// <summary>
        /// The maximum number of instances for scaling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_instances")]
        public int? MaxInstances { get; set; }

        /// <summary>
        /// The minimum number of instances for scaling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_instances")]
        public int? MinInstances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsListResponseResultCurrentReleaseConfiguration" /> class.
        /// </summary>
        /// <param name="hardware">
        /// The SKU for the hardware used to run the model.
        /// </param>
        /// <param name="maxInstances">
        /// The maximum number of instances for scaling.
        /// </param>
        /// <param name="minInstances">
        /// The minimum number of instances for scaling.
        /// </param>
        public DeploymentsListResponseResultCurrentReleaseConfiguration(
            string? hardware,
            int? maxInstances,
            int? minInstances)
        {
            this.Hardware = hardware;
            this.MaxInstances = maxInstances;
            this.MinInstances = minInstances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsListResponseResultCurrentReleaseConfiguration" /> class.
        /// </summary>
        public DeploymentsListResponseResultCurrentReleaseConfiguration()
        {
        }
    }
}