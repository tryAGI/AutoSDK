//HintName: G.JsonConverters.CitationsItem3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CitationsItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CitationsItem3>
    {
        /// <inheritdoc />
        public override global::G.CitationsItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestTextBlockCitationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestTextBlockCitationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestTextBlockCitationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RequestCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::G.RequestTextBlockCitationDiscriminatorType.CharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestCharLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestCharLocationCitation)}");
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequestPageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::G.RequestTextBlockCitationDiscriminatorType.PageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestPageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestPageLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestPageLocationCitation)}");
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RequestContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::G.RequestTextBlockCitationDiscriminatorType.ContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestContentBlockLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestContentBlockLocationCitation)}");
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.CitationsItem3(
                discriminator?.Type,
                charLocation,
                pageLocation,
                contentBlockLocation
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CitationsItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestCharLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestCharLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeInfo);
            }
            else if (value.IsPageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestPageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestPageLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestPageLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeInfo);
            }
            else if (value.IsContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestContentBlockLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestContentBlockLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeInfo);
            }
        }
    }
}