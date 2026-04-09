//HintName: G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType>
    {
        /// <inheritdoc />
        public override global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType existingValue,
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
                        return global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeExtensions.ToValueString(value));
        }
    }
}
