//HintName: G.JsonConverters.InputAudioBufferSpeechStartedPayloadType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class InputAudioBufferSpeechStartedPayloadTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.InputAudioBufferSpeechStartedPayloadType>
    {
        /// <inheritdoc />
        public override global::G.InputAudioBufferSpeechStartedPayloadType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.InputAudioBufferSpeechStartedPayloadType existingValue,
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
                        return global::G.InputAudioBufferSpeechStartedPayloadTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.InputAudioBufferSpeechStartedPayloadType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.InputAudioBufferSpeechStartedPayloadType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.InputAudioBufferSpeechStartedPayloadType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.InputAudioBufferSpeechStartedPayloadTypeExtensions.ToValueString(value));
        }
    }
}
