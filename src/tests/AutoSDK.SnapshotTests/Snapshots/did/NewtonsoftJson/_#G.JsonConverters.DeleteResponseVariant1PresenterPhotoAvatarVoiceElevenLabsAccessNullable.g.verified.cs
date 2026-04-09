//HintName: G.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?>
    {
        /// <inheritdoc />
        public override global::G.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? existingValue,
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
                        return global::G.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessExtensions.ToValueString(value.Value));
            }
        }
    }
}
