//HintName: G.JsonConverters.ParametersVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ParametersVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ParametersVariant1>
    {
        /// <inheritdoc />
        public override global::G.ParametersVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConfigurationUpdateRequestParametersVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConfigurationUpdateRequestParametersVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConfigurationUpdateRequestParametersVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SplitV1Parameters? splitV1 = default;
            if (discriminator?.ProductType == global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.SplitV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SplitV1Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SplitV1Parameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SplitV1Parameters)}");
                splitV1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ExtractV2Parameters? extractV2 = default;
            if (discriminator?.ProductType == global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.ExtractV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExtractV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExtractV2Parameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ExtractV2Parameters)}");
                extractV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ClassifyV2Parameters? classifyV2 = default;
            if (discriminator?.ProductType == global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.ClassifyV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClassifyV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClassifyV2Parameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClassifyV2Parameters)}");
                classifyV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ParseV2Parameters? parseV2 = default;
            if (discriminator?.ProductType == global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.ParseV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ParseV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ParseV2Parameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ParseV2Parameters)}");
                parseV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UntypedParameters? unknown = default;
            if (discriminator?.ProductType == global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.Unknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UntypedParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UntypedParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UntypedParameters)}");
                unknown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ParametersVariant1(
                discriminator?.ProductType,
                splitV1,

                extractV2,

                classifyV2,

                parseV2,

                unknown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ParametersVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSplitV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SplitV1Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SplitV1Parameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SplitV1Parameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SplitV1, typeInfo);
            }
            else if (value.IsExtractV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExtractV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExtractV2Parameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExtractV2Parameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExtractV2, typeInfo);
            }
            else if (value.IsClassifyV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClassifyV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClassifyV2Parameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClassifyV2Parameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClassifyV2, typeInfo);
            }
            else if (value.IsParseV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ParseV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ParseV2Parameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ParseV2Parameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParseV2, typeInfo);
            }
            else if (value.IsUnknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UntypedParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UntypedParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UntypedParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeInfo);
            }
        }
    }
}