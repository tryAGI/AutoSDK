﻿//HintName: G.Models.WebhookProjectsV2ItemConvertedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ItemConvertedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public global::G.WebhookProjectsV2ItemConvertedChangesContentType? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemConvertedChanges" /> class.
        /// </summary>
        /// <param name="contentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookProjectsV2ItemConvertedChanges(
            global::G.WebhookProjectsV2ItemConvertedChangesContentType? contentType)
        {
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemConvertedChanges" /> class.
        /// </summary>
        public WebhookProjectsV2ItemConvertedChanges()
        {
        }
    }
}