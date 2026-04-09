//HintName: G.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization?>
    {
        /// <inheritdoc />
        public override global::G.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization? existingValue,
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
                        return global::G.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}
