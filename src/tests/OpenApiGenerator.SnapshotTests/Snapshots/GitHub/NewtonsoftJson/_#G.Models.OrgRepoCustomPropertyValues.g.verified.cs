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
        [global::Newtonsoft.Json.JsonProperty("repository_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepositoryId { get; set; } = default!;

        /// <summary>
        /// Example: Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryName { get; set; } = default!;

        /// <summary>
        /// Example: octocat/Hello-World
        /// </summary>
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
    }
}