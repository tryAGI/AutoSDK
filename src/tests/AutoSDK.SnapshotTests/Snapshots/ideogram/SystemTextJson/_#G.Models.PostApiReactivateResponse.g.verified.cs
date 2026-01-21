//HintName: G.Models.PostApiReactivateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response to re-activating API settings.<br/>
    /// Example: {"recharge_settings":{"is_active":true}}
    /// </summary>
    public sealed partial class PostApiReactivateResponse
    {
        /// <summary>
        /// Example: {"is_active":true}
        /// </summary>
        /// <example>{"is_active":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recharge_settings")]
        public global::G.RechargeSettingsResponse? RechargeSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiReactivateResponse" /> class.
        /// </summary>
        /// <param name="rechargeSettings">
        /// Example: {"is_active":true}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostApiReactivateResponse(
            global::G.RechargeSettingsResponse? rechargeSettings)
        {
            this.RechargeSettings = rechargeSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiReactivateResponse" /> class.
        /// </summary>
        public PostApiReactivateResponse()
        {
        }
    }
}