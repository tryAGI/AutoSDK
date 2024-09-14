//HintName: JsonConverters.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel>
    {
        /// <inheritdoc />
        public override global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel Read(
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
                        return global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModelExtensions.ToValueString(value));
        }
    }
}
