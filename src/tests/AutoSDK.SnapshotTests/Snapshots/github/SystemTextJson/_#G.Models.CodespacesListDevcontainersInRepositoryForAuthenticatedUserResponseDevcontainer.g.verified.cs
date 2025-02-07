//HintName: G.Models.CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer(
            string path,
            string? name,
            string? displayName)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Name = name;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer" /> class.
        /// </summary>
        public CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer()
        {
        }
    }
}