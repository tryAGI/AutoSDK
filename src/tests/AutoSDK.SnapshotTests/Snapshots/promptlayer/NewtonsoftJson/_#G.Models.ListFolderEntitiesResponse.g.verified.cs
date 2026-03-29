//HintName: G.Models.ListFolderEntitiesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFolderEntitiesResponse
    {
        /// <summary>
        /// List of entities matching the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entities")]
        public global::System.Collections.Generic.IList<global::G.FolderEntity>? Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFolderEntitiesResponse" /> class.
        /// </summary>
        /// <param name="entities">
        /// List of entities matching the query.
        /// </param>
        public ListFolderEntitiesResponse(
            global::System.Collections.Generic.IList<global::G.FolderEntity>? entities)
        {
            this.Entities = entities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFolderEntitiesResponse" /> class.
        /// </summary>
        public ListFolderEntitiesResponse()
        {
        }
    }
}