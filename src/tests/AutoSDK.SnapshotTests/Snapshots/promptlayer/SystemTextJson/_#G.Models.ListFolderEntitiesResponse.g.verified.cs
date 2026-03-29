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
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::G.FolderEntity>? Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFolderEntitiesResponse" /> class.
        /// </summary>
        /// <param name="entities">
        /// List of entities matching the query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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