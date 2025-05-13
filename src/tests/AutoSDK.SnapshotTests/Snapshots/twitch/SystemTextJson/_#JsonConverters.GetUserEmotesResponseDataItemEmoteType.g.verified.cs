//HintName: JsonConverters.GetUserEmotesResponseDataItemEmoteType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetUserEmotesResponseDataItemEmoteTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetUserEmotesResponseDataItemEmoteType>
    {
        /// <inheritdoc />
        public override global::G.GetUserEmotesResponseDataItemEmoteType Read(
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
                        return global::G.GetUserEmotesResponseDataItemEmoteTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetUserEmotesResponseDataItemEmoteType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetUserEmotesResponseDataItemEmoteType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetUserEmotesResponseDataItemEmoteType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetUserEmotesResponseDataItemEmoteTypeExtensions.ToValueString(value));
        }
    }
}
