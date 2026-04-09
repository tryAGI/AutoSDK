//HintName: G.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2?>
    {
        /// <inheritdoc />
        public override global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2? existingValue,
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
                        return global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2Extensions.ToValueString(value.Value));
            }
        }
    }
}
