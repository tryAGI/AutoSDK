//HintName: G.JsonConverters.FeedsBackfillSubscriptionResponseErrorCode.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedsBackfillSubscriptionResponseErrorCodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FeedsBackfillSubscriptionResponseErrorCode>
    {
        /// <inheritdoc />
        public override global::G.FeedsBackfillSubscriptionResponseErrorCode Read(
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
                        return global::G.FeedsBackfillSubscriptionResponseErrorCodeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FeedsBackfillSubscriptionResponseErrorCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FeedsBackfillSubscriptionResponseErrorCode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FeedsBackfillSubscriptionResponseErrorCode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.FeedsBackfillSubscriptionResponseErrorCodeExtensions.ToValueString(value));
        }
    }
}
