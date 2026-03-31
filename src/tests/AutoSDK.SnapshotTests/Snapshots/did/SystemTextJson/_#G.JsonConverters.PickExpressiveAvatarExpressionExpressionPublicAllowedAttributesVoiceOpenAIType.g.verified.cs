//HintName: G.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAITypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIType>
    {
        /// <inheritdoc />
        public override global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIType Read(
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
                        return global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAITypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAITypeExtensions.ToValueString(value));
        }
    }
}
