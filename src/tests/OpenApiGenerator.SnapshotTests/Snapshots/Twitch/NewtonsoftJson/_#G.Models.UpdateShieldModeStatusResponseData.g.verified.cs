//HintName: G.Models.UpdateShieldModeStatusResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateShieldModeStatusResponseData
    {
        /// <summary>
        /// A Boolean value that determines whether Shield Mode is active. Is **true** if Shield Mode is active; otherwise, **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsActive { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the moderator that last activated Shield Mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorId { get; set; } = default!;

        /// <summary>
        /// The moderator’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorLogin { get; set; } = default!;

        /// <summary>
        /// The moderator’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorName { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp (in RFC3339 format) of when Shield Mode was last activated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_activated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastActivatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}