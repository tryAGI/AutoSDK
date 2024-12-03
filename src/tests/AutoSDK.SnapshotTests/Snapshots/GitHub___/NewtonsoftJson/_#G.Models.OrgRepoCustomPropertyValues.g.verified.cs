//HintName: G.Models.OrgRepoCustomPropertyValues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of custom property values for a repository
    /// </summary>
    public sealed partial class OrgRepoCustomPropertyValues
    {
        /// <summary>
        /// Example: 1296269
        /// </summary>
        /// <example>1296269</example>
        [global::Newtonsoft.Json.JsonProperty("repository_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepositoryId { get; set; } = default!;

        /// <summary>
        /// Example: Hello-World
        /// </summary>
        /// <example>Hello-World</example>
        [global::Newtonsoft.Json.JsonProperty("repository_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryName { get; set; } = default!;

        /// <summary>
        /// Example: octocat/Hello-World
        /// </summary>
        /// <example>octocat/Hello-World</example>
        [global::Newtonsoft.Json.JsonProperty("repository_full_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryFullName { get; set; } = default!;

        /// <summary>
        /// List of custom property names and associated values
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomPropertyValue> Properties { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgRepoCustomPropertyValues" /> class.
        /// </summary>
        /// <param name="repositoryId">
        /// Example: 1296269
        /// </param>
        /// <param name="repositoryName">
        /// Example: Hello-World
        /// </param>
        /// <param name="repositoryFullName">
        /// Example: octocat/Hello-World
        /// </param>
        /// <param name="properties">
        /// List of custom property names and associated values
        /// </param>
        public OrgRepoCustomPropertyValues(
            int repositoryId,
            string repositoryName,
            string repositoryFullName,
            global::System.Collections.Generic.IList<global::G.CustomPropertyValue> properties)
        {
            this.RepositoryId = repositoryId;
            this.RepositoryName = repositoryName ?? throw new global::System.ArgumentNullException(nameof(repositoryName));
            this.RepositoryFullName = repositoryFullName ?? throw new global::System.ArgumentNullException(nameof(repositoryFullName));
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgRepoCustomPropertyValues" /> class.
        /// </summary>
        public OrgRepoCustomPropertyValues()
        {
        }
    }
}