//HintName: G.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExpressiveAvatarExpressionDtoVariant1VoiceAmazonTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType?>
    {
        /// <inheritdoc />
        public override global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType? Read(
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
                        return global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
