//HintName: G.JsonConverters.AgentStepInstruction.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentStepInstructionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentStepInstruction>
    {
        /// <inheritdoc />
        public override global::G.AgentStepInstruction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentStepInstructionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentStepInstructionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentStepInstructionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ReferenceInstruction? reference = default;
            if (discriminator?.Type == global::G.AgentStepInstructionDiscriminatorType.Reference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReferenceInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReferenceInstruction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ReferenceInstruction)}");
                reference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineInstruction? inline = default;
            if (discriminator?.Type == global::G.AgentStepInstructionDiscriminatorType.Inline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineInstruction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineInstruction)}");
                inline = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AgentStepInstruction(
                discriminator?.Type,
                reference,

                inline
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentStepInstruction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReferenceInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReferenceInstruction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReferenceInstruction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reference!.Value, typeInfo);
            }
            else if (value.IsInline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineInstruction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineInstruction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Inline!.Value, typeInfo);
            }
        }
    }
}