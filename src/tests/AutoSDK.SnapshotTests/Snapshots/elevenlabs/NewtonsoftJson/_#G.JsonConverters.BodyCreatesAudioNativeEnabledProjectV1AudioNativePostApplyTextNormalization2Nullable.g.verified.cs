//HintName: G.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2?>
    {
        /// <inheritdoc />
        public override global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2? existingValue,
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
                        return global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2Extensions.ToValueString(value.Value));
            }
        }
    }
}
