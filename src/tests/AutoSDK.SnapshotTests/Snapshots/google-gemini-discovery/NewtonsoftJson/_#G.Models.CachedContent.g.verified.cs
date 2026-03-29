//HintName: G.Models.CachedContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Content that has been preprocessed and can be used in subsequent request to GenerativeService. Cached content can be only used with model it was created for.
    /// </summary>
    public sealed partial class CachedContent
    {
        /// <summary>
        /// Timestamp in UTC of when this resource is considered expired. This is *always* provided on output, regardless of what was sent on input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expireTime")]
        public string? ExpireTime { get; set; }

        /// <summary>
        /// Input only. New TTL for this resource, input only.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl")]
        public string? Ttl { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name referring to the cached content. Format: `cachedContents/{id}`<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional. Immutable. The user-generated meaningful display name of the cached content. Maximum 128 Unicode characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Required. Immutable. The name of the `Model` to use for cached content Format: `models/{model}`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("systemInstruction")]
        public global::G.Content? SystemInstruction { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. The content to cache.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public global::System.Collections.Generic.IList<global::G.Content>? Contents { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. A list of `Tools` the model may use to generate the next response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolConfig")]
        public global::G.ToolConfig? ToolConfig { get; set; }

        /// <summary>
        /// Output only. Creation time of the cache entry.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Output only. When the cache entry was last updated in UTC time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Metadata on the usage of the cached content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usageMetadata")]
        public global::G.CachedContentUsageMetadata? UsageMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CachedContent" /> class.
        /// </summary>
        /// <param name="expireTime">
        /// Timestamp in UTC of when this resource is considered expired. This is *always* provided on output, regardless of what was sent on input.
        /// </param>
        /// <param name="ttl">
        /// Input only. New TTL for this resource, input only.
        /// </param>
        /// <param name="name">
        /// Output only. Identifier. The resource name referring to the cached content. Format: `cachedContents/{id}`<br/>
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Optional. Immutable. The user-generated meaningful display name of the cached content. Maximum 128 Unicode characters.
        /// </param>
        /// <param name="model">
        /// Required. Immutable. The name of the `Model` to use for cached content Format: `models/{model}`
        /// </param>
        /// <param name="systemInstruction">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="contents">
        /// Optional. Input only. Immutable. The content to cache.
        /// </param>
        /// <param name="tools">
        /// Optional. Input only. Immutable. A list of `Tools` the model may use to generate the next response
        /// </param>
        /// <param name="toolConfig">
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </param>
        /// <param name="createTime">
        /// Output only. Creation time of the cache entry.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Output only. When the cache entry was last updated in UTC time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usageMetadata">
        /// Metadata on the usage of the cached content.
        /// </param>
        public CachedContent(
            string? expireTime,
            string? ttl,
            string? name,
            string? displayName,
            string? model,
            global::G.Content? systemInstruction,
            global::System.Collections.Generic.IList<global::G.Content>? contents,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.ToolConfig? toolConfig,
            string? createTime,
            string? updateTime,
            global::G.CachedContentUsageMetadata? usageMetadata)
        {
            this.ExpireTime = expireTime;
            this.Ttl = ttl;
            this.Name = name;
            this.DisplayName = displayName;
            this.Model = model;
            this.SystemInstruction = systemInstruction;
            this.Contents = contents;
            this.Tools = tools;
            this.ToolConfig = toolConfig;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.UsageMetadata = usageMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CachedContent" /> class.
        /// </summary>
        public CachedContent()
        {
        }
    }
}