//HintName: G.Models.WebhookProjectsV2StatusUpdateEditedChangesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2StatusUpdateEditedChangesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookProjectsV2StatusUpdateEditedChangesStatusFromJsonConverter))]
        public global::G.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookProjectsV2StatusUpdateEditedChangesStatusToJsonConverter))]
        public global::G.WebhookProjectsV2StatusUpdateEditedChangesStatusTo? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2StatusUpdateEditedChangesStatus" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookProjectsV2StatusUpdateEditedChangesStatus(
            global::G.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom? from,
            global::G.WebhookProjectsV2StatusUpdateEditedChangesStatusTo? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2StatusUpdateEditedChangesStatus" /> class.
        /// </summary>
        public WebhookProjectsV2StatusUpdateEditedChangesStatus()
        {
        }
    }
}