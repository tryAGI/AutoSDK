//HintName: G.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class OnlineScoreConfigScorerVariant2GlobalTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OnlineScoreConfigScorerVariant2GlobalType?>
    {
        /// <inheritdoc />
        public override global::G.OnlineScoreConfigScorerVariant2GlobalType? Read(
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
                        return global::G.OnlineScoreConfigScorerVariant2GlobalTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.OnlineScoreConfigScorerVariant2GlobalType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.OnlineScoreConfigScorerVariant2GlobalType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OnlineScoreConfigScorerVariant2GlobalType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.OnlineScoreConfigScorerVariant2GlobalTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
