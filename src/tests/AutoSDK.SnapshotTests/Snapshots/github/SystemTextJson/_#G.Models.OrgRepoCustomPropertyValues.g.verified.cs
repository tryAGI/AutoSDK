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
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepositoryId { get; set; }

        /// <summary>
        /// Example: Hello-World
        /// </summary>
        /// <example>Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryName { get; set; }

        /// <summary>
        /// Example: octocat/Hello-World
        /// </summary>
        /// <example>octocat/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryFullName { get; set; }

        /// <summary>
        /// List of custom property names and associated values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CustomPropertyValue> Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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