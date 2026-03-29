//HintName: G.Models.OpenAIChatRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIChatRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema")]
        public object? JsonSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestResponseFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="jsonSchema"></param>
        public OpenAIChatRequestResponseFormat(
            string type,
            object? jsonSchema)
        {
            this.JsonSchema = jsonSchema;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestResponseFormat" /> class.
        /// </summary>
        public OpenAIChatRequestResponseFormat()
        {
        }
    }
}