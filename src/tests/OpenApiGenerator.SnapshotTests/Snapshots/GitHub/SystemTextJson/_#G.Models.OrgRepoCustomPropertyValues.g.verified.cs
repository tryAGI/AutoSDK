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
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepositoryId { get; set; }

        /// <summary>
        /// Example: Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryName { get; set; }

        /// <summary>
        /// Example: octocat/Hello-World
        /// </summary>
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
    }
}