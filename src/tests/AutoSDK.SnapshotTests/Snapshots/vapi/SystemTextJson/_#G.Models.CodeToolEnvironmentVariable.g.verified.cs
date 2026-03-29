//HintName: G.Models.CodeToolEnvironmentVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeToolEnvironmentVariable
    {
        /// <summary>
        /// Name of the environment variable<br/>
        /// Example: API_KEY
        /// </summary>
        /// <example>API_KEY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Value of the environment variable. Supports Liquid templates.<br/>
        /// Example: {{apiKey}}
        /// </summary>
        /// <example>{{apiKey}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeToolEnvironmentVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment variable<br/>
        /// Example: API_KEY
        /// </param>
        /// <param name="value">
        /// Value of the environment variable. Supports Liquid templates.<br/>
        /// Example: {{apiKey}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeToolEnvironmentVariable(
            string name,
            string value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeToolEnvironmentVariable" /> class.
        /// </summary>
        public CodeToolEnvironmentVariable()
        {
        }
    }
}