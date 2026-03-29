//HintName: G.Models.TrackMetadataRequestMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary of metadata items to associate with the request. Can include session_ids, user_ids, location, etc.
    /// </summary>
    public sealed partial class TrackMetadataRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}