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
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
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