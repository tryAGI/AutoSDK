//HintName: G.Models.AssetRelationships.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exported_mesh")]
        public global::G.AssetRelationshipsExportedMesh? ExportedMesh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetRelationships" /> class.
        /// </summary>
        /// <param name="exportedMesh"></param>
        public AssetRelationships(
            global::G.AssetRelationshipsExportedMesh? exportedMesh)
        {
            this.ExportedMesh = exportedMesh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetRelationships" /> class.
        /// </summary>
        public AssetRelationships()
        {
        }
    }
}