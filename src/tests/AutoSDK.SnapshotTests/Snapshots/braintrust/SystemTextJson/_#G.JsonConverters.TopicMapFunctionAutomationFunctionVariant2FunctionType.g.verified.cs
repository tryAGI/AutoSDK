//HintName: G.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopicMapFunctionAutomationFunctionVariant2FunctionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TopicMapFunctionAutomationFunctionVariant2FunctionType>
    {
        /// <inheritdoc />
        public override global::G.TopicMapFunctionAutomationFunctionVariant2FunctionType Read(
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
                        return global::G.TopicMapFunctionAutomationFunctionVariant2FunctionTypeExtensions.ToEnum(stringValue) ?? default;
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
                    return default(global::G.TopicMapFunctionAutomationFunctionVariant2FunctionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TopicMapFunctionAutomationFunctionVariant2FunctionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TopicMapFunctionAutomationFunctionVariant2FunctionTypeExtensions.ToValueString(value));
        }
    }
}
