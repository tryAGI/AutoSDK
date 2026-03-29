//HintName: G.Models.AssetResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public global::G.AvatarAttributes? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public global::G.AssetLinks? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relationships")]
        public global::G.AssetRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="attributes"></param>
        /// <param name="links"></param>
        /// <param name="relationships"></param>
        public AssetResource(
            string? type,
            global::System.Guid? id,
            global::G.AvatarAttributes? attributes,
            global::G.AssetLinks? links,
            global::G.AssetRelationships? relationships)
        {
            this.Type = type;
            this.Id = id;
            this.Attributes = attributes;
            this.Links = links;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResource" /> class.
        /// </summary>
        public AssetResource()
        {
        }
    }
}