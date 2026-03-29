//HintName: G.Models.AssetRelationshipsExportedMesh.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetRelationshipsExportedMesh
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.RelationshipItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetRelationshipsExportedMesh" /> class.
        /// </summary>
        /// <param name="data"></param>
        public AssetRelationshipsExportedMesh(
            global::System.Collections.Generic.IList<global::G.RelationshipItem>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetRelationshipsExportedMesh" /> class.
        /// </summary>
        public AssetRelationshipsExportedMesh()
        {
        }
    }
}