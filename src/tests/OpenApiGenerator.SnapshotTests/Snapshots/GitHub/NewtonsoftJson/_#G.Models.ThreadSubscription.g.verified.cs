﻿//HintName: G.Models.ThreadSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Thread Subscription
    /// </summary>
    public sealed partial class ThreadSubscription
    {
        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscribed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Subscribed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignored", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Ignored { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Reason { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/notifications/threads/1/subscription
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/notifications/threads/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_url")]
        public string? ThreadUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_url")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}