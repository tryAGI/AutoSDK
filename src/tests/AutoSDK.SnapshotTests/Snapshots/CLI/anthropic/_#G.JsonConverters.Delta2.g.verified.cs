//HintName: G.JsonConverters.Delta2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Delta2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Delta2>
    {
        /// <inheritdoc />
        public override global::G.Delta2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentBlockDeltaEventDeltaDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentBlockDeltaEventDeltaDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContentBlockDeltaEventDeltaDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextContentBlockDelta? textDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.TextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextContentBlockDelta)}");
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InputJsonContentBlockDelta? inputJsonDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputJsonContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputJsonContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InputJsonContentBlockDelta)}");
                inputJsonDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CitationsDelta? citationsDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CitationsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CitationsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CitationsDelta)}");
                citationsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ThinkingContentBlockDelta? thinkingDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ThinkingContentBlockDelta)}");
                thinkingDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SignatureContentBlockDelta? signatureDelta = default;
            if (discriminator?.Type == global::G.ContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SignatureContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SignatureContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SignatureContentBlockDelta)}");
                signatureDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Delta2(
                discriminator?.Type,
                textDelta,
                inputJsonDelta,
                citationsDelta,
                thinkingDelta,
                signatureDelta
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Delta2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeInfo);
            }
            else if (value.IsInputJsonDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputJsonContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputJsonContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputJsonContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJsonDelta, typeInfo);
            }
            else if (value.IsCitationsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CitationsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CitationsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CitationsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationsDelta, typeInfo);
            }
            else if (value.IsThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ThinkingContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDelta, typeInfo);
            }
            else if (value.IsSignatureDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SignatureContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SignatureContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SignatureContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SignatureDelta, typeInfo);
            }
        }
    }
}