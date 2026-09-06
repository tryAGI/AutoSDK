//HintName: G.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat>
    {
        /// <inheritdoc />
        public override global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat existingValue,
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
                        return global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatExtensions.ToValueString(value));
        }
    }
}
