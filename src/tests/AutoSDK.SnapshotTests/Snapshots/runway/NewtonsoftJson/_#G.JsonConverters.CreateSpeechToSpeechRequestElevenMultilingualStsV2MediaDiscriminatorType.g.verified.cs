//HintName: G.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType existingValue,
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
                        return global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
