﻿//HintName: G.Models.V1WebhookEndpointAddRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1WebhookEndpointAddRequest
    {
        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<object>? Events { get; set; }

        /// <summary>
        /// Example: &lt;url&gt;
        /// </summary>
        /// <example>&lt;url&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1WebhookEndpointAddRequest" /> class.
        /// </summary>
        /// <param name="events">
        /// Example: []
        /// </param>
        /// <param name="url">
        /// Example: &lt;url&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1WebhookEndpointAddRequest(
            global::System.Collections.Generic.IList<object>? events,
            string? url)
        {
            this.Events = events;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1WebhookEndpointAddRequest" /> class.
        /// </summary>
        public V1WebhookEndpointAddRequest()
        {
        }
    }
}