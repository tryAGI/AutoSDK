//HintName: G.Models.InteractionLimitResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Interaction limit settings.
    /// </summary>
    public sealed partial class InteractionLimitResponse
    {
        /// <summary>
        /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.<br/>
        /// Example: collaborators_only
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InteractionGroup? Limit { get; set; } = default!;

        /// <summary>
        /// Example: repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin", Required = global::Newtonsoft.Json.Required.Always)]
        public string Origin { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}