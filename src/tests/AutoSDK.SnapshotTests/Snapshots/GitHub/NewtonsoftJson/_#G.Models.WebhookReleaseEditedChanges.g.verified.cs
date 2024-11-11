//HintName: G.Models.WebhookReleaseEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookReleaseEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public global::G.WebhookReleaseEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.WebhookReleaseEditedChangesName? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("make_latest")]
        public global::G.WebhookReleaseEditedChangesMakeLatest? MakeLatest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleaseEditedChanges" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="makeLatest"></param>
        public WebhookReleaseEditedChanges(
            global::G.WebhookReleaseEditedChangesBody? body,
            global::G.WebhookReleaseEditedChangesName? name,
            global::G.WebhookReleaseEditedChangesMakeLatest? makeLatest)
        {
            this.Body = body;
            this.Name = name;
            this.MakeLatest = makeLatest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleaseEditedChanges" /> class.
        /// </summary>
        public WebhookReleaseEditedChanges()
        {
        }
    }
}