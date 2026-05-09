//HintName: G.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType? existingValue,
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
                        return global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
