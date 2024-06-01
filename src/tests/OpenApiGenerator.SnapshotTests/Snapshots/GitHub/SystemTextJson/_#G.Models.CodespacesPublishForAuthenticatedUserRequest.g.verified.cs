//HintName: G.Models.CodespacesPublishForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesPublishForAuthenticatedUserRequest
    {
        /// <summary>
        /// A name for the new repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the new repository should be private.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool Private { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}