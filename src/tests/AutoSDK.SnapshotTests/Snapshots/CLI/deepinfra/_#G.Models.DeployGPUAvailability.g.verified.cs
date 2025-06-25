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
        [global::System.Text.Json.Serialization.JsonPropertyName("gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GPUAvailabilityInfo> Gpus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployGPUAvailability" /> class.
        /// </summary>
        /// <param name="gpus">
        /// A list of all provided GPUs configurations, including their price and wether they are available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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