//HintName: G.JsonConverters.WebhooksPreviousMarketplacePurchasePlanPriceModel.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksPreviousMarketplacePurchasePlanPriceModelJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhooksPreviousMarketplacePurchasePlanPriceModel>
    {
        /// <inheritdoc />
        public override global::G.WebhooksPreviousMarketplacePurchasePlanPriceModel ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhooksPreviousMarketplacePurchasePlanPriceModel existingValue,
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
                        return global::G.WebhooksPreviousMarketplacePurchasePlanPriceModelExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhooksPreviousMarketplacePurchasePlanPriceModel)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhooksPreviousMarketplacePurchasePlanPriceModel);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhooksPreviousMarketplacePurchasePlanPriceModel value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhooksPreviousMarketplacePurchasePlanPriceModelExtensions.ToValueString(value));
        }
    }
}
