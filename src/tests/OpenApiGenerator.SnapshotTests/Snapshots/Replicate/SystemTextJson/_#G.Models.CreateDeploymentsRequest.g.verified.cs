//HintName: G.Models.CreateDeploymentsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentsRequest
    {
        /// <summary>
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hardware { get; set; }

        /// <summary>
        /// The maximum number of instances for scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_instances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxInstances { get; set; }

        /// <summary>
        /// The minimum number of instances for scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_instances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinInstances { get; set; }

        /// <summary>
        /// The full name of the model that you want to deploy e.g. stability-ai/sdxl.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The 64-character string ID of the model version that you want to deploy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}