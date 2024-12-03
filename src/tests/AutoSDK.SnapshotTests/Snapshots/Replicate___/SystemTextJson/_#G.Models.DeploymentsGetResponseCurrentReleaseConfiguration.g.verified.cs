//HintName: G.Models.DeploymentsGetResponseCurrentReleaseConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsGetResponseCurrentReleaseConfiguration
    {
        /// <summary>
        /// The SKU for the hardware used to run the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        public string? Hardware { get; set; }

        /// <summary>
        /// The maximum number of instances for scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_instances")]
        public int? MaxInstances { get; set; }

        /// <summary>
        /// The minimum number of instances for scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_instances")]
        public int? MinInstances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsGetResponseCurrentReleaseConfiguration" /> class.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeploymentsGetResponseCurrentReleaseConfiguration(
            string? hardware,
            int? maxInstances,
            int? minInstances)
        {
            this.Hardware = hardware;
            this.MaxInstances = maxInstances;
            this.MinInstances = minInstances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsGetResponseCurrentReleaseConfiguration" /> class.
        /// </summary>
        public DeploymentsGetResponseCurrentReleaseConfiguration()
        {
        }
    }
}