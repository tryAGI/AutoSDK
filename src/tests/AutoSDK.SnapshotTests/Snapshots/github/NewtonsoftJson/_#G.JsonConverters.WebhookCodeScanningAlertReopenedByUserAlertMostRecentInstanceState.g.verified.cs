//HintName: G.JsonConverters.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceStateJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState>
    {
        /// <inheritdoc />
        public override global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState existingValue,
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
                        return global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceStateExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceStateExtensions.ToValueString(value));
        }
    }
}
