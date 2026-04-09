//HintName: G.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedsListSubscriptionsResponseSubscriptionMergeStrategyNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy?>
    {
        /// <inheritdoc />
        public override global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy? existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategyExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategyExtensions.ToValueString(value.Value));
            }
        }
    }
}
