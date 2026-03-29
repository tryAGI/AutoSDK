//HintName: G.Models.ListProjectTracesSessionIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of session identifiers to filter traces by. Each value can be either a session_id string or a session GlobalID. Only traces belonging to the specified sessions will be returned.
    /// </summary>
    public sealed partial class ListProjectTracesSessionIdentifier
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}