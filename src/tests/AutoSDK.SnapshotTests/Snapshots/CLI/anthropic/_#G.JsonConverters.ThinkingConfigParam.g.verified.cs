//HintName: G.JsonConverters.ThinkingConfigParam.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ThinkingConfigParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ThinkingConfigParam>
    {
        /// <inheritdoc />
        public override global::G.ThinkingConfigParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingConfigParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingConfigParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ThinkingConfigParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ThinkingConfigEnabled? enabled = default;
            if (discriminator?.Type == global::G.ThinkingConfigParamDiscriminatorType.Enabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingConfigEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingConfigEnabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ThinkingConfigEnabled)}");
                enabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ThinkingConfigDisabled? disabled = default;
            if (discriminator?.Type == global::G.ThinkingConfigParamDiscriminatorType.Disabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingConfigDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingConfigDisabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ThinkingConfigDisabled)}");
                disabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ThinkingConfigParam(
                discriminator?.Type,
                enabled,
                disabled
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ThinkingConfigParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEnabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingConfigEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingConfigEnabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ThinkingConfigEnabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enabled, typeInfo);
            }
            else if (value.IsDisabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingConfigDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingConfigDisabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ThinkingConfigDisabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeInfo);
            }
        }
    }
}