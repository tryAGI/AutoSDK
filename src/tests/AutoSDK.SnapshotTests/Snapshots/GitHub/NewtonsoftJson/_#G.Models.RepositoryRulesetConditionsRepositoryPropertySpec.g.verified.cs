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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The values to match for the repository property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("property_values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> PropertyValues { get; set; } = default!;

        /// <summary>
        /// The source of the repository property. Defaults to 'custom' if not specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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