//HintName: G.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity>
    {
        /// <inheritdoc />
        public override global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity existingValue,
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
                        return global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityExtensions.ToValueString(value));
        }
    }
}
