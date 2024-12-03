//HintName: G.Models.OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest
    {
        /// <summary>
        /// The names of repositories that the custom property values will be applied to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RepositoryNames { get; set; }

        /// <summary>
        /// List of custom property names and associated values to apply to the repositories.
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
        /// Initializes a new instance of the <see cref="OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest" /> class.
        /// </summary>
        /// <param name="repositoryNames">
        /// The names of repositories that the custom property values will be applied to.
        /// </param>
        /// <param name="properties">
        /// List of custom property names and associated values to apply to the repositories.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest(
            global::System.Collections.Generic.IList<string> repositoryNames,
            global::System.Collections.Generic.IList<global::G.CustomPropertyValue> properties)
        {
            this.RepositoryNames = repositoryNames ?? throw new global::System.ArgumentNullException(nameof(repositoryNames));
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest" /> class.
        /// </summary>
        public OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest()
        {
        }
    }
}