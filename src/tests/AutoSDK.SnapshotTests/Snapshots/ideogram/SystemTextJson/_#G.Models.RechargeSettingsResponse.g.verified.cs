//HintName: G.Models.RechargeSettingsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RechargeSettingsResponse
    {
        /// <summary>
        /// Whether or not the recharge setting is currently active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RechargeSettingsResponse" /> class.
        /// </summary>
        /// <param name="isActive">
        /// Whether or not the recharge setting is currently active.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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