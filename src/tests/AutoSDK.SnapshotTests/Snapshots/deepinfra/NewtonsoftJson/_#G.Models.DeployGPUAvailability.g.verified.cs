//HintName: G.Models.DeployGPUAvailability.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployGPUAvailability
    {
        /// <summary>
        /// A list of all provided GPUs configurations, including their price and wether they are available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gpus", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GPUAvailabilityInfo> Gpus { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployGPUAvailability" /> class.
        /// </summary>
        /// <param name="gpus">
        /// A list of all provided GPUs configurations, including their price and wether they are available
        /// </param>
        public DeployGPUAvailability(
            global::System.Collections.Generic.IList<global::G.GPUAvailabilityInfo> gpus)
        {
            this.Gpus = gpus ?? throw new global::System.ArgumentNullException(nameof(gpus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployGPUAvailability" /> class.
        /// </summary>
        public DeployGPUAvailability()
        {
        }
    }
}