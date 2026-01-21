//HintName: G.Models.RechargeSettingsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"is_active":true}
    /// </summary>
    public sealed partial class RechargeSettingsResponse
    {
        /// <summary>
        /// Whether or not the recharge setting is currently active.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsActive { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RechargeSettingsResponse" /> class.
        /// </summary>
        /// <param name="isActive">
        /// Whether or not the recharge setting is currently active.
        /// </param>
        public RechargeSettingsResponse(
            bool isActive)
        {
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RechargeSettingsResponse" /> class.
        /// </summary>
        public RechargeSettingsResponse()
        {
        }
    }
}