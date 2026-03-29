//HintName: G.Models.PostCliCodactFailuresRequestSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary session payload from the CLI.<br/>
    /// Example: {"id":"sess_123","model":"gpt-5.2"}
    /// </summary>
    public sealed partial class PostCliCodactFailuresRequestSession
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}