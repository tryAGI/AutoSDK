//HintName: G.Models.ChatCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A section of the generated reply which cites external knowledge.
    /// </summary>
    public sealed partial class ChatCitation
    {
        /// <summary>
        /// The index of text that the citation starts at, counting from zero. For example, a generation of `Hello, world!` with a citation on `world` would have a start value of `7`. This is because the citation starts at `w`, which is the seventh character.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The index of text that the citation ends after, counting from zero. For example, a generation of `Hello, world!` with a citation on `world` would have an end value of `11`. This is because the citation ends after `d`, which is the eleventh character.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The text of the citation. For example, a generation of `Hello, world!` with a citation of `world` would have a text value of `world`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Identifiers of documents cited by this section of the generated reply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DocumentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitation" /> class.
        /// </summary>
        /// <param name="start">
        /// The index of text that the citation starts at, counting from zero. For example, a generation of `Hello, world!` with a citation on `world` would have a start value of `7`. This is because the citation starts at `w`, which is the seventh character.
        /// </param>
        /// <param name="end">
        /// The index of text that the citation ends after, counting from zero. For example, a generation of `Hello, world!` with a citation on `world` would have an end value of `11`. This is because the citation ends after `d`, which is the eleventh character.
        /// </param>
        /// <param name="text">
        /// The text of the citation. For example, a generation of `Hello, world!` with a citation of `world` would have a text value of `world`.
        /// </param>
        /// <param name="documentIds">
        /// Identifiers of documents cited by this section of the generated reply.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCitation(
            int start,
            int end,
            string text,
            global::System.Collections.Generic.IList<string> documentIds)
        {
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.DocumentIds = documentIds ?? throw new global::System.ArgumentNullException(nameof(documentIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitation" /> class.
        /// </summary>
        public ChatCitation()
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
        public static global::G.ChatCitation? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ChatCitation),
                jsonSerializerContext) as global::G.ChatCitation;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ChatCitation? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCitation>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ChatCitation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ChatCitation),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ChatCitation;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ChatCitation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ChatCitation?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}