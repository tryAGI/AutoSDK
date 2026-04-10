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
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VapiSmartEndpointingPlanProviderJsonConverter))]
        public global::G.VapiSmartEndpointingPlanProvider Provider { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiSmartEndpointingPlan" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the provider for the smart endpointing plan.<br/>
        /// Example: vapi
        /// </param>
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