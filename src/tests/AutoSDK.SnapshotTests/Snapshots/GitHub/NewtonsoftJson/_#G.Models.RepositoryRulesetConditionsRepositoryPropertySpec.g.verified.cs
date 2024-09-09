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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}