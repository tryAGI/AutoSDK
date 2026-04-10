//HintName: G.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelId.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodySpeechToTextV1SpeechToTextPostModelId>
    {
        /// <inheritdoc />
        public override global::G.BodySpeechToTextV1SpeechToTextPostModelId ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodySpeechToTextV1SpeechToTextPostModelId existingValue,
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
                        return global::G.BodySpeechToTextV1SpeechToTextPostModelIdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodySpeechToTextV1SpeechToTextPostModelId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodySpeechToTextV1SpeechToTextPostModelId);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodySpeechToTextV1SpeechToTextPostModelId value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BodySpeechToTextV1SpeechToTextPostModelIdExtensions.ToValueString(value));
        }
    }
}
