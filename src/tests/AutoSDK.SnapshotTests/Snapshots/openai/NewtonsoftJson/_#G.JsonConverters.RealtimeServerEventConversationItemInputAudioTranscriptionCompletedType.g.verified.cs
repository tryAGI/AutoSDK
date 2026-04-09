//HintName: G.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType>
    {
        /// <inheritdoc />
        public override global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType existingValue,
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
                        return global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeExtensions.ToValueString(value));
        }
    }
}
