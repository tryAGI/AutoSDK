//HintName: G.Models.CollectionConfigMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary JSON metadata for the collection This can be used to store application-specific information such as creation time, migration data, inference model info, etc.
    /// </summary>
    public sealed partial class CollectionConfigMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}