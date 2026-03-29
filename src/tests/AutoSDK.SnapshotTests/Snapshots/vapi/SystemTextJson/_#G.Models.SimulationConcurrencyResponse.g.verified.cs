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
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Max call slots for simulations (each voice simulation uses 2 call slots: tester + target)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyLimit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConcurrencyLimit { get; set; }

        /// <summary>
        /// Number of call slots currently in use by running simulations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeSimulations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActiveSimulations { get; set; }

        /// <summary>
        /// Number of voice simulations that can start now (available call slots / 2)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableToStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvailableToStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// True if org is using platform default concurrency limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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