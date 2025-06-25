﻿//HintName: G.JsonConverters.BetaThinkingConfigParam.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BetaThinkingConfigParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BetaThinkingConfigParam>
    {
        /// <inheritdoc />
        public override global::G.BetaThinkingConfigParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaThinkingConfigParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaThinkingConfigParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaThinkingConfigParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaThinkingConfigEnabled? enabled = default;
            if (discriminator?.Type == global::G.BetaThinkingConfigParamDiscriminatorType.Enabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaThinkingConfigEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaThinkingConfigEnabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaThinkingConfigEnabled)}");
                enabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaThinkingConfigDisabled? disabled = default;
            if (discriminator?.Type == global::G.BetaThinkingConfigParamDiscriminatorType.Disabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaThinkingConfigDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaThinkingConfigDisabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaThinkingConfigDisabled)}");
                disabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.BetaThinkingConfigParam(
                discriminator?.Type,
                enabled,
                disabled
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BetaThinkingConfigParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEnabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaThinkingConfigEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaThinkingConfigEnabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaThinkingConfigEnabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enabled, typeInfo);
            }
            else if (value.IsDisabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaThinkingConfigDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaThinkingConfigDisabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaThinkingConfigDisabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeInfo);
            }
        }
    }
}