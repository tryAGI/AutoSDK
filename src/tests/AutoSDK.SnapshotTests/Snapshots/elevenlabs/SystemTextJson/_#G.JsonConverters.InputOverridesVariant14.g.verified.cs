//HintName: G.JsonConverters.InputOverridesVariant14.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputOverridesVariant14JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputOverridesVariant14>
    {
        /// <inheritdoc />
        public override global::G.InputOverridesVariant14 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ConstantSchemaOverride? constant = default;
            if (discriminator?.Source == global::G.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.Constant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConstantSchemaOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConstantSchemaOverride> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConstantSchemaOverride)}");
                constant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DynamicVariableSchemaOverride? dynamicVariable = default;
            if (discriminator?.Source == global::G.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.DynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicVariableSchemaOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicVariableSchemaOverride> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DynamicVariableSchemaOverride)}");
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LLMSchemaOverride? llm = default;
            if (discriminator?.Source == global::G.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMSchemaOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMSchemaOverride> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LLMSchemaOverride)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.InputOverridesVariant14(
                discriminator?.Source,
                constant,

                dynamicVariable,

                llm
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputOverridesVariant14 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConstant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConstantSchemaOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConstantSchemaOverride?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConstantSchemaOverride).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Constant!, typeInfo);
            }
            else if (value.IsDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicVariableSchemaOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicVariableSchemaOverride?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DynamicVariableSchemaOverride).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable!, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMSchemaOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMSchemaOverride?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMSchemaOverride).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm!, typeInfo);
            }
        }
    }
}