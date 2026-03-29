//HintName: G.Models.UpdateCollectionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata to update for the collection. If provided, this will merge with existing metadata. To remove metadata, set it to an empty object.
    /// </summary>
    public sealed partial class UpdateCollectionMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}