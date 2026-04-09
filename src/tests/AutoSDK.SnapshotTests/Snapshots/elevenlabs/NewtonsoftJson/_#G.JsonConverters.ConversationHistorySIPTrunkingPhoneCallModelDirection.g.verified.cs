//HintName: G.JsonConverters.ConversationHistorySIPTrunkingPhoneCallModelDirection.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationHistorySIPTrunkingPhoneCallModelDirectionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ConversationHistorySIPTrunkingPhoneCallModelDirection>
    {
        /// <inheritdoc />
        public override global::G.ConversationHistorySIPTrunkingPhoneCallModelDirection ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ConversationHistorySIPTrunkingPhoneCallModelDirection existingValue,
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
                        return global::G.ConversationHistorySIPTrunkingPhoneCallModelDirectionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ConversationHistorySIPTrunkingPhoneCallModelDirection)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ConversationHistorySIPTrunkingPhoneCallModelDirection);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ConversationHistorySIPTrunkingPhoneCallModelDirection value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ConversationHistorySIPTrunkingPhoneCallModelDirectionExtensions.ToValueString(value));
        }
    }
}
