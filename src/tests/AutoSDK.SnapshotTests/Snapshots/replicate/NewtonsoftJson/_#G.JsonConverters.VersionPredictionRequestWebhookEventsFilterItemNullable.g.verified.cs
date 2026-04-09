//HintName: G.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class VersionPredictionRequestWebhookEventsFilterItemNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.VersionPredictionRequestWebhookEventsFilterItem?>
    {
        /// <inheritdoc />
        public override global::G.VersionPredictionRequestWebhookEventsFilterItem? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.VersionPredictionRequestWebhookEventsFilterItem? existingValue,
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
                        return global::G.VersionPredictionRequestWebhookEventsFilterItemExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.VersionPredictionRequestWebhookEventsFilterItem)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.VersionPredictionRequestWebhookEventsFilterItem?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.VersionPredictionRequestWebhookEventsFilterItem? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.VersionPredictionRequestWebhookEventsFilterItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
