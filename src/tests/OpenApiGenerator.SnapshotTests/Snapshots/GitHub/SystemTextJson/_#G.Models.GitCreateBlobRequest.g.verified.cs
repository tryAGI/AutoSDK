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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The encoding used for `content`. Currently, `"utf-8"` and `"base64"` are supported.
        /// <br/>Default Value: utf-8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        public string? Encoding { get; set; } = "utf-8";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}