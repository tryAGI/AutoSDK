//HintName: G.Models.SessionUserMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).
    /// </summary>
    public sealed partial class SessionUserMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}