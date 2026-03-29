//HintName: G.Models.VariableExtractionAlias.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VariableExtractionAlias
    {
        /// <summary>
        /// This is the key of the variable.<br/>
        /// This variable will be accessible during the call as `{{key}}` and stored in `call.artifact.variableValues` after the call.<br/>
        /// Rules:<br/>
        /// - Must start with a letter (a-z, A-Z).<br/>
        /// - Subsequent characters can be letters, numbers, or underscores.<br/>
        /// - Minimum length of 1 and maximum length of 40.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// This is the value of the variable.<br/>
        /// This can reference existing variables, use filters, and perform transformations.<br/>
        /// Examples: "{{name}}", "{{customer.email}}", "Hello {{name | upcase}}"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableExtractionAlias" /> class.
        /// </summary>
        /// <param name="key">
        /// This is the key of the variable.<br/>
        /// This variable will be accessible during the call as `{{key}}` and stored in `call.artifact.variableValues` after the call.<br/>
        /// Rules:<br/>
        /// - Must start with a letter (a-z, A-Z).<br/>
        /// - Subsequent characters can be letters, numbers, or underscores.<br/>
        /// - Minimum length of 1 and maximum length of 40.
        /// </param>
        /// <param name="value">
        /// This is the value of the variable.<br/>
        /// This can reference existing variables, use filters, and perform transformations.<br/>
        /// Examples: "{{name}}", "{{customer.email}}", "Hello {{name | upcase}}"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VariableExtractionAlias(
            string key,
            string value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableExtractionAlias" /> class.
        /// </summary>
        public VariableExtractionAlias()
        {
        }
    }
}