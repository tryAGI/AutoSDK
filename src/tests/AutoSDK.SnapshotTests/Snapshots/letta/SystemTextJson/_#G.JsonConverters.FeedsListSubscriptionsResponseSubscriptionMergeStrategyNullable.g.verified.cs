//HintName: G.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedsListSubscriptionsResponseSubscriptionMergeStrategyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy?>
    {
        /// <inheritdoc />
        public override global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy? Read(
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
                        return global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategyExtensions.ToValueString(value.Value));
            }
        }
    }
}
