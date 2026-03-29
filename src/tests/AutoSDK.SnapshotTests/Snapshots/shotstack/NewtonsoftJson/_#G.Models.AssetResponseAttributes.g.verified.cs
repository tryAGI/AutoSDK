//HintName: G.Models.AssetResponseAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The list of asset attributes and their values.
    /// </summary>
    public sealed partial class AssetResponseAttributes
    {
        /// <summary>
        /// The unique id of the hosted asset in UUID format.<br/>
        /// Example: a4482cbf-e321-42a2-ac8b-947d26886840
        /// </summary>
        /// <example>a4482cbf-e321-42a2-ac8b-947d26886840</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The owner id of the asset.<br/>
        /// Example: 5ca6hu7s9k
        /// </summary>
        /// <example>5ca6hu7s9k</example>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// The region the asset is hosted, currently only `au` (Australia).<br/>
        /// Example: au
        /// </summary>
        /// <example>au</example>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The original render id that created the asset in UUID format. Multiple assets can share the same render id.<br/>
        /// Example: 2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7
        /// </summary>
        /// <example>2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7</example>
        [global::Newtonsoft.Json.JsonProperty("renderId")]
        public string? RenderId { get; set; }

        /// <summary>
        /// The third party id of an asset transferred to an external provider, i.e. Mux, YouTube or S3. If the provider is Shotstack, the providerID is the same as the asset id.<br/>
        /// Example: a4482cbf-e321-42a2-ac8b-947d26886840
        /// </summary>
        /// <example>a4482cbf-e321-42a2-ac8b-947d26886840</example>
        [global::Newtonsoft.Json.JsonProperty("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// The asset file name.<br/>
        /// Example: 2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7.mp4
        /// </summary>
        /// <example>2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The asset file name.<br/>
        /// Example: https://cdn.shotstack.io/au/v1/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7.mp4
        /// </summary>
        /// <example>https://cdn.shotstack.io/au/v1/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The status of the asset. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`importing` - the asset is being copied to the hosting service&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ready` - the asset is ready to be served to users&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - the asset failed to copy or delete&lt;/li&gt;<br/>
        ///   &lt;li&gt;`deleted` - the asset has been deleted&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: ready
        /// </summary>
        /// <example>ready</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssetResponseAttributesStatus Status { get; set; } = default!;

        /// <summary>
        /// The time the asset was created.<br/>
        /// Example: 2021-06-30T09:42:29.446Z
        /// </summary>
        /// <example>2021-06-30T09:42:29.446Z</example>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public string? Created { get; set; }

        /// <summary>
        /// The time the asset status was last updated.<br/>
        /// Example: 2021-06-30T09:42:30.168Z
        /// </summary>
        /// <example>2021-06-30T09:42:30.168Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponseAttributes" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique id of the hosted asset in UUID format.<br/>
        /// Example: a4482cbf-e321-42a2-ac8b-947d26886840
        /// </param>
        /// <param name="owner">
        /// The owner id of the asset.<br/>
        /// Example: 5ca6hu7s9k
        /// </param>
        /// <param name="status">
        /// The status of the asset. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`importing` - the asset is being copied to the hosting service&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ready` - the asset is ready to be served to users&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - the asset failed to copy or delete&lt;/li&gt;<br/>
        ///   &lt;li&gt;`deleted` - the asset has been deleted&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: ready
        /// </param>
        /// <param name="region">
        /// The region the asset is hosted, currently only `au` (Australia).<br/>
        /// Example: au
        /// </param>
        /// <param name="renderId">
        /// The original render id that created the asset in UUID format. Multiple assets can share the same render id.<br/>
        /// Example: 2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7
        /// </param>
        /// <param name="providerId">
        /// The third party id of an asset transferred to an external provider, i.e. Mux, YouTube or S3. If the provider is Shotstack, the providerID is the same as the asset id.<br/>
        /// Example: a4482cbf-e321-42a2-ac8b-947d26886840
        /// </param>
        /// <param name="filename">
        /// The asset file name.<br/>
        /// Example: 2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7.mp4
        /// </param>
        /// <param name="url">
        /// The asset file name.<br/>
        /// Example: https://cdn.shotstack.io/au/v1/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7.mp4
        /// </param>
        /// <param name="created">
        /// The time the asset was created.<br/>
        /// Example: 2021-06-30T09:42:29.446Z
        /// </param>
        /// <param name="updated">
        /// The time the asset status was last updated.<br/>
        /// Example: 2021-06-30T09:42:30.168Z
        /// </param>
        public AssetResponseAttributes(
            string id,
            string owner,
            global::G.AssetResponseAttributesStatus status,
            string? region,
            string? renderId,
            string? providerId,
            string? filename,
            string? url,
            string? created,
            string? updated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Region = region;
            this.RenderId = renderId;
            this.ProviderId = providerId;
            this.Filename = filename;
            this.Url = url;
            this.Status = status;
            this.Created = created;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponseAttributes" /> class.
        /// </summary>
        public AssetResponseAttributes()
        {
        }
    }
}