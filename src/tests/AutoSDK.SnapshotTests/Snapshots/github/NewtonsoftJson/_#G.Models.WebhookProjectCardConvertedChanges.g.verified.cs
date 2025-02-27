﻿//HintName: G.Models.WebhookProjectCardConvertedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectCardConvertedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookProjectCardConvertedChangesNote Note { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardConvertedChanges" /> class.
        /// </summary>
        /// <param name="note"></param>
        public WebhookProjectCardConvertedChanges(
            global::G.WebhookProjectCardConvertedChangesNote note)
        {
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardConvertedChanges" /> class.
        /// </summary>
        public WebhookProjectCardConvertedChanges()
        {
        }
    }
}