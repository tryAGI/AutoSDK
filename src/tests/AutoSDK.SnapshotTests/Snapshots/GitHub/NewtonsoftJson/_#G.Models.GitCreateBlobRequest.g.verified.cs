//HintName: G.Models.GitCreateBlobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitCreateBlobRequest
    {
        /// <summary>
        /// The new blob's content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// The encoding used for `content`. Currently, `"utf-8"` and `"base64"` are supported.<br/>
        /// Default Value: utf-8
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding")]
        public string? Encoding { get; set; } = "utf-8";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}