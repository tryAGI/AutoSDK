//HintName: G.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId existingValue,
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
                        return global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdExtensions.ToValueString(value));
        }
    }
}
