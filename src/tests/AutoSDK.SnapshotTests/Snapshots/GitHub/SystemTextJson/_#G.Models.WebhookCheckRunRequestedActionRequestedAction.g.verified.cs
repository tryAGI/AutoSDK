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
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckRunRequestedActionRequestedAction" /> class.
        /// </summary>
        /// <param name="identifier">
        /// The integrator reference of the action requested by the user.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookCheckRunRequestedActionRequestedAction(
            string? identifier)
        {
            this.Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckRunRequestedActionRequestedAction" /> class.
        /// </summary>
        public WebhookCheckRunRequestedActionRequestedAction()
        {
        }
    }
}