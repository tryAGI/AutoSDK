//HintName: G.Models.ToolCustom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A custom tool the model may use.
    /// </summary>
    public sealed partial class ToolCustom
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the tool. Must match the regex `^[a-zA-Z0-9_-]{1,64}$`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of what this tool does.<br/>
        /// Tool descriptions should be as detailed as possible. The more information that<br/>
        /// the model has about what the tool is and how to use it, the better it will<br/>
        /// perform. You can use natural language descriptions to reinforce important<br/>
        /// aspects of the tool input JSON schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// [JSON schema](https://json-schema.org/) for this tool's input.<br/>
        /// This defines the shape of the `input` that your tool accepts and that the model<br/>
        /// will produce.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object InputSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCustom" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool.
        /// </param>
        /// <param name="name">
        /// The name of the tool. Must match the regex `^[a-zA-Z0-9_-]{1,64}$`.
        /// </param>
        /// <param name="description">
        /// Description of what this tool does.<br/>
        /// Tool descriptions should be as detailed as possible. The more information that<br/>
        /// the model has about what the tool is and how to use it, the better it will<br/>
        /// perform. You can use natural language descriptions to reinforce important<br/>
        /// aspects of the tool input JSON schema.
        /// </param>
        /// <param name="inputSchema">
        /// [JSON schema](https://json-schema.org/) for this tool's input.<br/>
        /// This defines the shape of the `input` that your tool accepts and that the model<br/>
        /// will produce.
        /// </param>
        public ToolCustom(
            string name,
            object inputSchema,
            string? type,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Type = type;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCustom" /> class.
        /// </summary>
        public ToolCustom()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ToolCustom? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ToolCustom>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ToolCustom?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ToolCustom?>(serializer.Deserialize<global::G.ToolCustom>(jsonReader));
        }

    }
}