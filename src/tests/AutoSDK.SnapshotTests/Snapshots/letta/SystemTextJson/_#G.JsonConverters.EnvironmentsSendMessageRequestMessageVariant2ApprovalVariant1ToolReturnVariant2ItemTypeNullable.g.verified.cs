//HintName: G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType?>
    {
        /// <inheritdoc />
        public override global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType? Read(
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
                        return global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
