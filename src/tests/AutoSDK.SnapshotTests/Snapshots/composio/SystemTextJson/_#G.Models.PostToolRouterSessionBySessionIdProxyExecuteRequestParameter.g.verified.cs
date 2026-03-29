//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdProxyExecuteRequestParameter
    {
        /// <summary>
        /// Parameter name<br/>
        /// Example: x-api-key
        /// </summary>
        /// <example>x-api-key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Parameter value<br/>
        /// Example: abc123def456
        /// </summary>
        /// <example>abc123def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Parameter type (header or query)<br/>
        /// Example: header
        /// </summary>
        /// <example>header</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestParameter" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdProxyExecuteRequestParameter(
            string name,
            string value,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestParameter" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteRequestParameter()
        {
        }
    }
}