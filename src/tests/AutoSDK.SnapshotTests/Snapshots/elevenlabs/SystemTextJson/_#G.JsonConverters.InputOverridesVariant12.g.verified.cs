//HintName: G.JsonConverters.InputOverridesVariant12.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputOverridesVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputOverridesVariant12>
    {
        /// <inheritdoc />
        public override global::G.InputOverridesVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPToolConfigOutputInputOverridesDiscriminator>(ref readerCopy, options);

            global::G.ConstantSchemaOverride? constant = default;
            if (discriminator?.Source == global::G.MCPToolConfigOutputInputOverridesDiscriminatorSource.Constant)
            {
                constant = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConstantSchemaOverride>(ref reader, options);
            }
            global::G.DynamicVariableSchemaOverride? dynamicVariable = default;
            if (discriminator?.Source == global::G.MCPToolConfigOutputInputOverridesDiscriminatorSource.DynamicVariable)
            {
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DynamicVariableSchemaOverride>(ref reader, options);
            }
            global::G.LLMSchemaOverride? llm = default;
            if (discriminator?.Source == global::G.MCPToolConfigOutputInputOverridesDiscriminatorSource.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMSchemaOverride>(ref reader, options);
            }

            var __value = new global::G.InputOverridesVariant12(
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
            global::G.InputOverridesVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsConstant)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Constant, typeof(global::G.ConstantSchemaOverride), options);
            }
            else if (value.IsDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeof(global::G.DynamicVariableSchemaOverride), options);
            }
            else if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::G.LLMSchemaOverride), options);
            }
        }
    }
}