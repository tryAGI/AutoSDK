//HintName: G.JsonConverters.WebSocketResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class WebSocketResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebSocketResponse>
    {
        /// <inheritdoc />
        public override global::G.WebSocketResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSocketResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WebSocketResponseVariant1? chunk = default;
            if (discriminator?.Type == "chunk")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSocketResponseVariant1)}");
                chunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSocketResponseVariant2? flushDone = default;
            if (discriminator?.Type == "flush_done")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSocketResponseVariant2)}");
                flushDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSocketResponseVariant3? done = default;
            if (discriminator?.Type == "done")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSocketResponseVariant3)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSocketResponseVariant4? timestamps = default;
            if (discriminator?.Type == "timestamps")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSocketResponseVariant4)}");
                timestamps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSocketResponseVariant5? error = default;
            if (discriminator?.Type == "error")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSocketResponseVariant5)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSocketResponseVariant6? phonemeTimestamps = default;
            if (discriminator?.Type == "phoneme_timestamps")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSocketResponseVariant6)}");
                phonemeTimestamps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.WebSocketResponse(
                discriminator?.Type,
                chunk,

                flushDone,

                done,

                timestamps,

                error,

                phonemeTimestamps
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebSocketResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chunk!, typeInfo);
            }
            else if (value.IsFlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlushDone!, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done!, typeInfo);
            }
            else if (value.IsTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Timestamps!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsPhonemeTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhonemeTimestamps!, typeInfo);
            }
        }
    }
}