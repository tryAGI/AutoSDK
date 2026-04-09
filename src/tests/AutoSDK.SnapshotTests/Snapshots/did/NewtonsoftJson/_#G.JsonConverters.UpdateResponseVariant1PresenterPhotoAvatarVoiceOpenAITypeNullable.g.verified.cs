//HintName: G.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?>
    {
        /// <inheritdoc />
        public override global::G.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType? existingValue,
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
                        return global::G.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
