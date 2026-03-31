//HintName: G.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopicMapFunctionAutomationFunctionVariant2FunctionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TopicMapFunctionAutomationFunctionVariant2FunctionType?>
    {
        /// <inheritdoc />
        public override global::G.TopicMapFunctionAutomationFunctionVariant2FunctionType? Read(
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
                        return global::G.TopicMapFunctionAutomationFunctionVariant2FunctionTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TopicMapFunctionAutomationFunctionVariant2FunctionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TopicMapFunctionAutomationFunctionVariant2FunctionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TopicMapFunctionAutomationFunctionVariant2FunctionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.TopicMapFunctionAutomationFunctionVariant2FunctionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
