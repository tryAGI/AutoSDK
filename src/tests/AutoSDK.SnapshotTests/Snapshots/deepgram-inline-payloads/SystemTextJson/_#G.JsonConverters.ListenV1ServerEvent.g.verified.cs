//HintName: G.JsonConverters.ListenV1ServerEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ListenV1ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListenV1ServerEvent>
    {
        /// <inheritdoc />
        public override global::G.ListenV1ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListenV1ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListenV1ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListenV1ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ListenV1Results? results = default;
            if (discriminator?.Type == global::G.ListenV1ServerEventDiscriminatorType.Results)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListenV1Results), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListenV1Results> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListenV1Results)}");
                results = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListenV1Metadata? metadata = default;
            if (discriminator?.Type == global::G.ListenV1ServerEventDiscriminatorType.Metadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListenV1Metadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListenV1Metadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListenV1Metadata)}");
                metadata = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ListenV1ServerEvent(
                discriminator?.Type,
                results,

                metadata
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListenV1ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListenV1Results), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListenV1Results?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListenV1Results).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Results!, typeInfo);
            }
            else if (value.IsMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListenV1Metadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListenV1Metadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListenV1Metadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Metadata!, typeInfo);
            }
        }
    }
}