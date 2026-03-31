//HintName: G.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptDataNullishToolFunctionVariant2FunctionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PromptDataNullishToolFunctionVariant2FunctionType>
    {
        /// <inheritdoc />
        public override global::G.PromptDataNullishToolFunctionVariant2FunctionType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.PromptDataNullishToolFunctionVariant2FunctionTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PromptDataNullishToolFunctionVariant2FunctionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PromptDataNullishToolFunctionVariant2FunctionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PromptDataNullishToolFunctionVariant2FunctionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PromptDataNullishToolFunctionVariant2FunctionTypeExtensions.ToValueString(value));
        }
    }
}
