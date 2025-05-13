﻿//HintName: JsonConverters.WebhookCodeScanningAlertFixedAlertMostRecentInstanceStateNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookCodeScanningAlertFixedAlertMostRecentInstanceStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookCodeScanningAlertFixedAlertMostRecentInstanceState?>
    {
        /// <inheritdoc />
        public override global::G.WebhookCodeScanningAlertFixedAlertMostRecentInstanceState? Read(
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
                        return global::G.WebhookCodeScanningAlertFixedAlertMostRecentInstanceStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookCodeScanningAlertFixedAlertMostRecentInstanceState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookCodeScanningAlertFixedAlertMostRecentInstanceState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookCodeScanningAlertFixedAlertMostRecentInstanceState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookCodeScanningAlertFixedAlertMostRecentInstanceStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
