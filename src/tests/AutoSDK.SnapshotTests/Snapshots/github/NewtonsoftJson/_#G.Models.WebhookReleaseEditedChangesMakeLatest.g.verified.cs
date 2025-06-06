﻿//HintName: G.Models.WebhookReleaseEditedChangesMakeLatest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookReleaseEditedChangesMakeLatest
    {
        /// <summary>
        /// Whether this release was explicitly `edited` to be the latest.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public bool To { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleaseEditedChangesMakeLatest" /> class.
        /// </summary>
        /// <param name="to">
        /// Whether this release was explicitly `edited` to be the latest.
        /// </param>
        public WebhookReleaseEditedChangesMakeLatest(
            bool to)
        {
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleaseEditedChangesMakeLatest" /> class.
        /// </summary>
        public WebhookReleaseEditedChangesMakeLatest()
        {
        }
    }
}