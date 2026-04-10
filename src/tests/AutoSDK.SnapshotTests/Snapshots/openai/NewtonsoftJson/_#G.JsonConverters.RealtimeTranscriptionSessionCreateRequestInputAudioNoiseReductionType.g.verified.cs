//HintName: G.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType>
    {
        /// <inheritdoc />
        public override global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType existingValue,
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
                        return global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionTypeExtensions.ToValueString(value));
        }
    }
}
