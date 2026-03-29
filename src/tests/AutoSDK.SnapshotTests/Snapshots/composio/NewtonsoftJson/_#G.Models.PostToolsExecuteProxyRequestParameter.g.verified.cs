//HintName: G.Models.PostToolsExecuteProxyRequestParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteProxyRequestParameter
    {
        /// <summary>
        /// Parameter name<br/>
        /// Example: x-api-key
        /// </summary>
        /// <example>x-api-key</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Parameter value<br/>
        /// Example: abc123def456
        /// </summary>
        /// <example>abc123def456</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Parameter type (header or query)<br/>
        /// Example: header
        /// </summary>
        /// <example>header</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostToolsExecuteProxyRequestParameterType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestParameter" /> class.
        /// </summary>
        /// <param name="name">
        /// Parameter name<br/>
        /// Example: x-api-key
        /// </param>
        /// <param name="value">
        /// Parameter value<br/>
        /// Example: abc123def456
        /// </param>
        /// <param name="type">
        /// Parameter type (header or query)<br/>
        /// Example: header
        /// </param>
        public PostToolsExecuteProxyRequestParameter(
            string name,
            string value,
            global::G.PostToolsExecuteProxyRequestParameterType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestParameter" /> class.
        /// </summary>
        public PostToolsExecuteProxyRequestParameter()
        {
        }
    }
}