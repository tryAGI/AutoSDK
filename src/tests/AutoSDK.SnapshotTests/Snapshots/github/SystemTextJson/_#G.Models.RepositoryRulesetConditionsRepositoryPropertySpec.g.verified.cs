//HintName: G.Models.RepositoryRulesetConditionsRepositoryPropertySpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for a targeting a repository property
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryPropertySpec
    {
        /// <summary>
        /// The name of the repository property to target
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The values to match for the repository property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PropertyValues { get; set; }

        /// <summary>
        /// The source of the repository property. Defaults to 'custom' if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRulesetConditionsRepositoryPropertySpecSourceJsonConverter))]
        public global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryPropertySpec" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the repository property to target
        /// </param>
        /// <param name="propertyValues">
        /// The values to match for the repository property
        /// </param>
        /// <param name="source">
        /// The source of the repository property. Defaults to 'custom' if not specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRulesetConditionsRepositoryPropertySpec(
            string name,
            global::System.Collections.Generic.IList<string> propertyValues,
            global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource? source)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PropertyValues = propertyValues ?? throw new global::System.ArgumentNullException(nameof(propertyValues));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryPropertySpec" /> class.
        /// </summary>
        public RepositoryRulesetConditionsRepositoryPropertySpec()
        {
        }
    }
}