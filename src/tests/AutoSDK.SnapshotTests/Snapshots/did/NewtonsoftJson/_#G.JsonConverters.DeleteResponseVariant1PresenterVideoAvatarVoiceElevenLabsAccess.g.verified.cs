//HintName: G.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess>
    {
        /// <inheritdoc />
        public override global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess existingValue,
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
                        return global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessExtensions.ToValueString(value));
        }
    }
}
