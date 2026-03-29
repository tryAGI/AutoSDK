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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Value of the environment variable. Supports Liquid templates.<br/>
        /// Example: {{apiKey}}
        /// </summary>
        /// <example>{{apiKey}}</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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