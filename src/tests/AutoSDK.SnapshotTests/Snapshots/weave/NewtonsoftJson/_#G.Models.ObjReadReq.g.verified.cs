//HintName: G.Models.ObjReadReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjReadReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// If true, the `val` column is not read from the database and is empty.All other fields are returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_only")]
        public bool? MetadataOnly { get; set; }

        /// <summary>
        /// If true, tags and aliases are fetched and included in the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_tags_and_aliases")]
        public bool? IncludeTagsAndAliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjReadReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="metadataOnly">
        /// If true, the `val` column is not read from the database and is empty.All other fields are returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTagsAndAliases">
        /// If true, tags and aliases are fetched and included in the response.<br/>
        /// Default Value: false
        /// </param>
        public ObjReadReq(
            string projectId,
            string objectId,
            string digest,
            bool? metadataOnly,
            bool? includeTagsAndAliases)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.MetadataOnly = metadataOnly;
            this.IncludeTagsAndAliases = includeTagsAndAliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjReadReq" /> class.
        /// </summary>
        public ObjReadReq()
        {
        }
    }
}