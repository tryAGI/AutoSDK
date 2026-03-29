//HintName: G.Models.SimulationConcurrencyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationConcurrencyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// Max call slots for simulations (each voice simulation uses 2 call slots: tester + target)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concurrencyLimit", Required = global::Newtonsoft.Json.Required.Always)]
        public double ConcurrencyLimit { get; set; } = default!;

        /// <summary>
        /// Number of call slots currently in use by running simulations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("activeSimulations", Required = global::Newtonsoft.Json.Required.Always)]
        public double ActiveSimulations { get; set; } = default!;

        /// <summary>
        /// Number of voice simulations that can start now (available call slots / 2)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("availableToStart", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvailableToStart { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// True if org is using platform default concurrency limit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isDefault", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDefault { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationConcurrencyResponse" /> class.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="concurrencyLimit">
        /// Max call slots for simulations (each voice simulation uses 2 call slots: tester + target)
        /// </param>
        /// <param name="activeSimulations">
        /// Number of call slots currently in use by running simulations
        /// </param>
        /// <param name="availableToStart">
        /// Number of voice simulations that can start now (available call slots / 2)
        /// </param>
        /// <param name="isDefault">
        /// True if org is using platform default concurrency limit
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public SimulationConcurrencyResponse(
            string orgId,
            double concurrencyLimit,
            double activeSimulations,
            double availableToStart,
            bool isDefault,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.ConcurrencyLimit = concurrencyLimit;
            this.ActiveSimulations = activeSimulations;
            this.AvailableToStart = availableToStart;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationConcurrencyResponse" /> class.
        /// </summary>
        public SimulationConcurrencyResponse()
        {
        }
    }
}