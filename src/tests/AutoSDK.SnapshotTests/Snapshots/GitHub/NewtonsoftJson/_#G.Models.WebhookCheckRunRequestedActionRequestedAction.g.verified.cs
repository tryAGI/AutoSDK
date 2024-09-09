//HintName: G.Models.WebhookCheckRunRequestedActionRequestedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action requested by the user.
    /// </summary>
    public sealed partial class WebhookCheckRunRequestedActionRequestedAction
    {
        /// <summary>
        /// The integrator reference of the action requested by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}