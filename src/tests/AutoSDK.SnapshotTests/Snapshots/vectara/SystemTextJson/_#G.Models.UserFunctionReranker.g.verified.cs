//HintName: G.Models.UserFunctionReranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserFunctionReranker
    {
        /// <summary>
        /// When the type is `userfn`, you can define custom reranking functions using document-level metadata,<br/>
        /// part-level metadata, or scores generated from the request-level metadata.<br/>
        /// Default Value: userfn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; } = "userfn";

        /// <summary>
        /// The user defined function.<br/>
        /// Example: get('$.score') * get('$.document_metadata.boost')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_function")]
        public string? UserFunction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}