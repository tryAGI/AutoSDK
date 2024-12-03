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
        /// Whether the new repository should be private.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPublishForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A name for the new repository.
        /// </param>
        /// <param name="private">
        /// Whether the new repository should be private.<br/>
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodespacesPublishForAuthenticatedUserRequest(
            string? name,
            bool? @private)
        {
            this.Name = name;
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPublishForAuthenticatedUserRequest" /> class.
        /// </summary>
        public CodespacesPublishForAuthenticatedUserRequest()
        {
        }
    }
}