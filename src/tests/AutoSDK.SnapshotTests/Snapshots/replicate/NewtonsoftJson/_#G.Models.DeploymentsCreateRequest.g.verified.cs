﻿//HintName: G.Models.DeploymentsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsCreateRequest
    {
        /// <summary>
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hardware", Required = global::Newtonsoft.Json.Required.Always)]
        public string Hardware { get; set; } = default!;

        /// <summary>
        /// The maximum number of instances for scaling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_instances", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxInstances { get; set; } = default!;

        /// <summary>
        /// The minimum number of instances for scaling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_instances", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinInstances { get; set; } = default!;

        /// <summary>
        /// The full name of the model that you want to deploy e.g. stability-ai/sdxl.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The 64-character string ID of the model version that you want to deploy.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsCreateRequest" /> class.
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
        /// <param name="model">
        /// The full name of the model that you want to deploy e.g. stability-ai/sdxl.
        /// </param>
        /// <param name="name">
        /// The name of the deployment.
        /// </param>
        /// <param name="version">
        /// The 64-character string ID of the model version that you want to deploy.
        /// </param>
        public DeploymentsCreateRequest(
            string hardware,
            int maxInstances,
            int minInstances,
            string model,
            string name,
            string version)
        {
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.MaxInstances = maxInstances;
            this.MinInstances = minInstances;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsCreateRequest" /> class.
        /// </summary>
        public DeploymentsCreateRequest()
        {
        }
    }
}