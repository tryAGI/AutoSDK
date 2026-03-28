//HintName: G.Models.DynamicVariableSchemaOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DynamicVariableSchemaOverride
    {
        /// <summary>
        /// Default Value: dynamic_variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The name of the dynamic variable to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DynamicVariable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableSchemaOverride" /> class.
        /// </summary>
        /// <param name="dynamicVariable">
        /// The name of the dynamic variable to use
        /// </param>
        /// <param name="source">
        /// Default Value: dynamic_variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicVariableSchemaOverride(
            string dynamicVariable,
            string? source)
        {
            this.Source = source;
            this.DynamicVariable = dynamicVariable ?? throw new global::System.ArgumentNullException(nameof(dynamicVariable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableSchemaOverride" /> class.
        /// </summary>
        public DynamicVariableSchemaOverride()
        {
        }
    }
}