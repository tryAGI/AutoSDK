//HintName: G.Models.HuggingFaceInferenceAPIEmbeddingHeaders.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional headers to send to the server. By default only the authorization and user-agent headers are sent. Values in this dictionary will override the default values.
    /// </summary>
    public sealed partial class HuggingFaceInferenceAPIEmbeddingHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}