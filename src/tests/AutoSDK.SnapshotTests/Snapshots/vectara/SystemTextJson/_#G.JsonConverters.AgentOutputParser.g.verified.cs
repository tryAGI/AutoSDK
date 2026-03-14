//HintName: G.JsonConverters.AgentOutputParser.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentOutputParserJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentOutputParser>
    {
        /// <inheritdoc />
        public override global::G.AgentOutputParser Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentOutputParserDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentOutputParserDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentOutputParserDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.DefaultOutputParser? @default = default;
            if (discriminator?.Type == global::G.AgentOutputParserDiscriminatorType.Default)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DefaultOutputParser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DefaultOutputParser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DefaultOutputParser)}");
                @default = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StructuredOutputParser? structured = default;
            if (discriminator?.Type == global::G.AgentOutputParserDiscriminatorType.Structured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredOutputParser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredOutputParser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StructuredOutputParser)}");
                structured = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AgentOutputParser(
                discriminator?.Type,
                @default,

                structured
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentOutputParser value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDefault)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DefaultOutputParser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DefaultOutputParser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DefaultOutputParser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Default, typeInfo);
            }
            else if (value.IsStructured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredOutputParser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredOutputParser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StructuredOutputParser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Structured, typeInfo);
            }
        }
    }
}