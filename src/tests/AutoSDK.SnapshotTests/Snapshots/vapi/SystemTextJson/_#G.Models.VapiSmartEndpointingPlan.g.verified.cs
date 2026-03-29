//HintName: G.Models.VapiSmartEndpointingPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiSmartEndpointingPlan
    {
        /// <summary>
        /// This is the provider for the smart endpointing plan.<br/>
        /// Example: vapi
        /// </summary>
        /// <example>vapi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VapiSmartEndpointingPlanProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VapiSmartEndpointingPlanProvider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiSmartEndpointingPlan" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the provider for the smart endpointing plan.<br/>
        /// Example: vapi
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VapiSmartEndpointingPlan(
            global::G.VapiSmartEndpointingPlanProvider provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiSmartEndpointingPlan" /> class.
        /// </summary>
        public VapiSmartEndpointingPlan()
        {
        }
    }
}