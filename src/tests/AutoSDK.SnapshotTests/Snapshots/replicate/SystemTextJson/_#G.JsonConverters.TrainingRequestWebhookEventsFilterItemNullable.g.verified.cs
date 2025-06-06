﻿//HintName: G.JsonConverters.TrainingRequestWebhookEventsFilterItemNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TrainingRequestWebhookEventsFilterItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TrainingRequestWebhookEventsFilterItem?>
    {
        /// <inheritdoc />
        public override global::G.TrainingRequestWebhookEventsFilterItem? Read(
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
                        return global::G.TrainingRequestWebhookEventsFilterItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TrainingRequestWebhookEventsFilterItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TrainingRequestWebhookEventsFilterItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TrainingRequestWebhookEventsFilterItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.TrainingRequestWebhookEventsFilterItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
