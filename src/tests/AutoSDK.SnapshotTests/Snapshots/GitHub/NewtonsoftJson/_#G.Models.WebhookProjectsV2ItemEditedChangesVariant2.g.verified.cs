//HintName: G.Models.WebhookProjectsV2ItemEditedChangesVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ItemEditedChangesVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookProjectsV2ItemEditedChangesVariant2Body Body { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEditedChangesVariant2" /> class.
        /// </summary>
        /// <param name="body"></param>
        public WebhookProjectsV2ItemEditedChangesVariant2(
            global::G.WebhookProjectsV2ItemEditedChangesVariant2Body body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEditedChangesVariant2" /> class.
        /// </summary>
        public WebhookProjectsV2ItemEditedChangesVariant2()
        {
        }
    }
}