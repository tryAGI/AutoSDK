//HintName: G.JsonConverters.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType?>
    {
        /// <inheritdoc />
        public override global::G.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType? Read(
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
                        return global::G.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
