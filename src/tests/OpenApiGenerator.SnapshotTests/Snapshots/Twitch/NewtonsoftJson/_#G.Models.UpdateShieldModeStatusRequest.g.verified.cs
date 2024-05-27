//HintName: G.Models.UpdateShieldModeStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateShieldModeStatusRequest
    {
        /// <summary>
        /// A Boolean value that determines whether to activate Shield Mode. Set to **true** to activate Shield Mode; otherwise, **false** to deactivate Shield Mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsActive { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}