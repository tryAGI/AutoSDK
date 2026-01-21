//HintName: G.Models.DynamicVariablesConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
    /// </summary>
    public sealed partial class DynamicVariablesConfig
    {
        /// <summary>
        /// A dictionary of dynamic variable placeholders and their values
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variable_placeholders")]
        public object? DynamicVariablePlaceholders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariablesConfig" /> class.
        /// </summary>
        /// <param name="dynamicVariablePlaceholders">
        /// A dictionary of dynamic variable placeholders and their values
        /// </param>
        public DynamicVariablesConfig(
            object? dynamicVariablePlaceholders)
        {
            this.DynamicVariablePlaceholders = dynamicVariablePlaceholders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariablesConfig" /> class.
        /// </summary>
        public DynamicVariablesConfig()
        {
        }
    }
}