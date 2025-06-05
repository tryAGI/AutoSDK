//HintName: G.Models.GPUAvailabilityInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUAvailabilityInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gpu_config", Required = global::Newtonsoft.Json.Required.Always)]
        public string GpuConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usd_per_hour", Required = global::Newtonsoft.Json.Required.Always)]
        public double UsdPerHour { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("available", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Available { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recommended")]
        public bool? Recommended { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUAvailabilityInfo" /> class.
        /// </summary>
        /// <param name="gpuConfig"></param>
        /// <param name="usdPerHour"></param>
        /// <param name="available"></param>
        /// <param name="recommended">
        /// Default Value: false
        /// </param>
        public GPUAvailabilityInfo(
            string gpuConfig,
            double usdPerHour,
            bool available,
            bool? recommended)
        {
            this.GpuConfig = gpuConfig ?? throw new global::System.ArgumentNullException(nameof(gpuConfig));
            this.UsdPerHour = usdPerHour;
            this.Available = available;
            this.Recommended = recommended;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUAvailabilityInfo" /> class.
        /// </summary>
        public GPUAvailabilityInfo()
        {
        }
    }
}