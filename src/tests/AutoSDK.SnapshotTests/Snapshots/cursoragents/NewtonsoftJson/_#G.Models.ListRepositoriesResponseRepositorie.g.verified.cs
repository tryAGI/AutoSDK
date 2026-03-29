//HintName: G.Models.ListRepositoriesResponseRepositorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListRepositoriesResponseRepositorie
    {
        /// <summary>
        /// The owner of the repository (user or organization)<br/>
        /// Example: your-org
        /// </summary>
        /// <example>your-org</example>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// The name of the repository<br/>
        /// Example: your-repo
        /// </summary>
        /// <example>your-repo</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The full URL to the GitHub repository<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </summary>
        /// <example>https://github.com/your-org/your-repo</example>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public string Repository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoriesResponseRepositorie" /> class.
        /// </summary>
        /// <param name="owner">
        /// The owner of the repository (user or organization)<br/>
        /// Example: your-org
        /// </param>
        /// <param name="name">
        /// The name of the repository<br/>
        /// Example: your-repo
        /// </param>
        /// <param name="repository">
        /// The full URL to the GitHub repository<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </param>
        public ListRepositoriesResponseRepositorie(
            string owner,
            string name,
            string repository)
        {
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoriesResponseRepositorie" /> class.
        /// </summary>
        public ListRepositoriesResponseRepositorie()
        {
        }
    }
}