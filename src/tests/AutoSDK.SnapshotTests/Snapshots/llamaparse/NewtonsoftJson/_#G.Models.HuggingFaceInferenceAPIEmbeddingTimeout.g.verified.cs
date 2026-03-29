//HintName: G.Models.HuggingFaceInferenceAPIEmbeddingTimeout.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The maximum number of seconds to wait for a response from the server. Loading a new model in Inference API can take up to several minutes. Defaults to None, meaning it will loop until the server is available.
    /// </summary>
    public sealed partial class HuggingFaceInferenceAPIEmbeddingTimeout
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}