//HintName: G.JsonConverters.Thinking.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ThinkingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Thinking>
    {
        /// <inheritdoc />
        public override global::G.Thinking Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAnthropicInvocationParametersContentThinkingDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAnthropicInvocationParametersContentThinkingDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAnthropicInvocationParametersContentThinkingDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PromptAnthropicThinkingConfigDisabled? disabled = default;
            if (discriminator?.Type == global::G.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType.Disabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAnthropicThinkingConfigDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAnthropicThinkingConfigDisabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAnthropicThinkingConfigDisabled)}");
                disabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptAnthropicThinkingConfigEnabled? enabled = default;
            if (discriminator?.Type == global::G.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType.Enabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAnthropicThinkingConfigEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAnthropicThinkingConfigEnabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAnthropicThinkingConfigEnabled)}");
                enabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Thinking(
                discriminator?.Type,
                disabled,

                enabled
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Thinking value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDisabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAnthropicThinkingConfigDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAnthropicThinkingConfigDisabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptAnthropicThinkingConfigDisabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled!, typeInfo);
            }
            else if (value.IsEnabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAnthropicThinkingConfigEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAnthropicThinkingConfigEnabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptAnthropicThinkingConfigEnabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enabled!, typeInfo);
            }
        }
    }
}