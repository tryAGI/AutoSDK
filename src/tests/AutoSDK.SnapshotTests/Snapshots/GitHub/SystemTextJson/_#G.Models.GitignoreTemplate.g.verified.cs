//HintName: G.Models.GitignoreTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gitignore Template
    /// </summary>
    public sealed partial class GitignoreTemplate
    {
        /// <summary>
        /// Example: C
        /// </summary>
        /// <example>C</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: # Object files<br/>
        /// *.o<br/>
        /// # Libraries<br/>
        /// *.lib<br/>
        /// *.a<br/>
        /// # Shared objects (inc. Windows DLLs)<br/>
        /// *.dll<br/>
        /// *.so<br/>
        /// *.so.*<br/>
        /// *.dylib<br/>
        /// # Executables<br/>
        /// *.exe<br/>
        /// *.out<br/>
        /// *.app
        /// </summary>
        /// <example>
        /// # Object files<br/>
        /// *.o<br/>
        /// # Libraries<br/>
        /// *.lib<br/>
        /// *.a<br/>
        /// # Shared objects (inc. Windows DLLs)<br/>
        /// *.dll<br/>
        /// *.so<br/>
        /// *.so.*<br/>
        /// *.dylib<br/>
        /// # Executables<br/>
        /// *.exe<br/>
        /// *.out<br/>
        /// *.app
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitignoreTemplate" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: C
        /// </param>
        /// <param name="source">
        /// Example: # Object files<br/>
        /// *.o<br/>
        /// # Libraries<br/>
        /// *.lib<br/>
        /// *.a<br/>
        /// # Shared objects (inc. Windows DLLs)<br/>
        /// *.dll<br/>
        /// *.so<br/>
        /// *.so.*<br/>
        /// *.dylib<br/>
        /// # Executables<br/>
        /// *.exe<br/>
        /// *.out<br/>
        /// *.app
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GitignoreTemplate(
            string name,
            string source)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitignoreTemplate" /> class.
        /// </summary>
        public GitignoreTemplate()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.GitignoreTemplate? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GitignoreTemplate),
                jsonSerializerContext) as global::G.GitignoreTemplate;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GitignoreTemplate? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GitignoreTemplate>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.GitignoreTemplate?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.GitignoreTemplate),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.GitignoreTemplate;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GitignoreTemplate?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.GitignoreTemplate?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}