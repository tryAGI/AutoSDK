//HintName: G.Models.DefaultOutputParser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Uses native tool calling capabilities and returns output directly to the user. This parser leverages the underlying model's built-in tool calling functionality and passes responses through without additional processing.
    /// </summary>
    public sealed partial class DefaultOutputParser
    {
        /// <summary>
        /// The type of output parser, which is always 'default' for this parser type.<br/>
        /// Default Value: default<br/>
        /// Example: default
        /// </summary>
        /// <default>"default"</default>
        /// <example>default</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultOutputParser" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of output parser, which is always 'default' for this parser type.<br/>
        /// Default Value: default<br/>
        /// Example: default
        /// </param>
        public DefaultOutputParser(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultOutputParser" /> class.
        /// </summary>
        public DefaultOutputParser()
        {
        }
    }
}