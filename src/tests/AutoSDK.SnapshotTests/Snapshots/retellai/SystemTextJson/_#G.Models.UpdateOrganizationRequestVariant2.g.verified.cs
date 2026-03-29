//HintName: G.Models.UpdateOrganizationRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateOrganizationRequestVariant2
    {
        /// <summary>
        /// Whether outage mode is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outage_mode_enabled")]
        public bool? OutageModeEnabled { get; set; }

        /// <summary>
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit (up to 3x or +300, whichever is lower) with a $0.10/min surcharge on burst calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_burst_enabled")]
        public bool? ConcurrencyBurstEnabled { get; set; }

        /// <summary>
        /// Whether to route calls and API requests from this organization to the stable server cluster (enterprise only). When enabled, a $0.02/min additional charge will be applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_stable_server")]
        public bool? UseStableServer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequestVariant2" /> class.
        /// </summary>
        /// <param name="outageModeEnabled">
        /// Whether outage mode is enabled
        /// </param>
        /// <param name="concurrencyBurstEnabled">
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit (up to 3x or +300, whichever is lower) with a $0.10/min surcharge on burst calls.
        /// </param>
        /// <param name="useStableServer">
        /// Whether to route calls and API requests from this organization to the stable server cluster (enterprise only). When enabled, a $0.02/min additional charge will be applied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationRequestVariant2(
            bool? outageModeEnabled,
            bool? concurrencyBurstEnabled,
            bool? useStableServer)
        {
            this.OutageModeEnabled = outageModeEnabled;
            this.ConcurrencyBurstEnabled = concurrencyBurstEnabled;
            this.UseStableServer = useStableServer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequestVariant2" /> class.
        /// </summary>
        public UpdateOrganizationRequestVariant2()
        {
        }
    }
}