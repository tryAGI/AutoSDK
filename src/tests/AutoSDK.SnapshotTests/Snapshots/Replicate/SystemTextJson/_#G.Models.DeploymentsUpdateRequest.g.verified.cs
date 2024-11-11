//HintName: G.Models.DeploymentsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsUpdateRequest
    {
        /// <summary>
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.
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
        /// The ID of the model version that you want to deploy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsUpdateRequest" /> class.
        /// </summary>
        /// <param name="hardware">
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.
        /// </param>
        /// <param name="maxInstances">
        /// The maximum number of instances for scaling.
        /// </param>
        /// <param name="minInstances">
        /// The minimum number of instances for scaling.
        /// </param>
        /// <param name="version">
        /// The ID of the model version that you want to deploy
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeploymentsUpdateRequest(
            string? hardware,
            int? maxInstances,
            int? minInstances,
            string? version)
        {
            this.Hardware = hardware;
            this.MaxInstances = maxInstances;
            this.MinInstances = minInstances;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsUpdateRequest" /> class.
        /// </summary>
        public DeploymentsUpdateRequest()
        {
        }
    }
}