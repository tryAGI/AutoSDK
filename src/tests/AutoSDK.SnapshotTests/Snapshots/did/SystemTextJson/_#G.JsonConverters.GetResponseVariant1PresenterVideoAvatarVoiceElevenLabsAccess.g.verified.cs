//HintName: G.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess>
    {
        /// <inheritdoc />
        public override global::G.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessExtensions.ToValueString(value));
        }
    }
}
