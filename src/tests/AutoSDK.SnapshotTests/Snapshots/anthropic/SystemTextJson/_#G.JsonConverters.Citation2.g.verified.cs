﻿//HintName: G.JsonConverters.Citation2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Citation2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Citation2>
    {
        /// <inheritdoc />
        public override global::G.Citation2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CitationsDeltaCitationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CitationsDeltaCitationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CitationsDeltaCitationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResponseCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::G.CitationsDeltaCitationDiscriminatorType.CharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCharLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseCharLocationCitation)}");
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponsePageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::G.CitationsDeltaCitationDiscriminatorType.PageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponsePageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponsePageLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponsePageLocationCitation)}");
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::G.CitationsDeltaCitationDiscriminatorType.ContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentBlockLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseContentBlockLocationCitation)}");
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Citation2(
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
            global::G.Citation2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCharLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCharLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeInfo);
            }
            else if (value.IsPageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponsePageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponsePageLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponsePageLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeInfo);
            }
            else if (value.IsContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentBlockLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentBlockLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeInfo);
            }
        }
    }
}