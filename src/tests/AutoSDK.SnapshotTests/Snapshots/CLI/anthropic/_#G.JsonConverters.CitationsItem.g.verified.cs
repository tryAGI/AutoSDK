//HintName: G.JsonConverters.CitationsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CitationsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CitationsItem>
    {
        /// <inheritdoc />
        public override global::G.CitationsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestTextBlockCitationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestTextBlockCitationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaRequestTextBlockCitationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaRequestCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::G.BetaRequestTextBlockCitationDiscriminatorType.CharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestCharLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaRequestCharLocationCitation)}");
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaRequestPageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::G.BetaRequestTextBlockCitationDiscriminatorType.PageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestPageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestPageLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaRequestPageLocationCitation)}");
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaRequestContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::G.BetaRequestTextBlockCitationDiscriminatorType.ContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestContentBlockLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaRequestContentBlockLocationCitation)}");
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.CitationsItem(
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
            global::G.CitationsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestCharLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaRequestCharLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeInfo);
            }
            else if (value.IsPageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestPageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestPageLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaRequestPageLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeInfo);
            }
            else if (value.IsContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestContentBlockLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaRequestContentBlockLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeInfo);
            }
        }
    }
}