//HintName: G.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedsListSubscriptionHistoryResponseRunStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FeedsListSubscriptionHistoryResponseRunStatus>
    {
        /// <inheritdoc />
        public override global::G.FeedsListSubscriptionHistoryResponseRunStatus Read(
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
                        return global::G.FeedsListSubscriptionHistoryResponseRunStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FeedsListSubscriptionHistoryResponseRunStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FeedsListSubscriptionHistoryResponseRunStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FeedsListSubscriptionHistoryResponseRunStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.FeedsListSubscriptionHistoryResponseRunStatusExtensions.ToValueString(value));
        }
    }
}
