//HintName: G.JsonConverters.UpdatePresenterAttributesVariant1VoiceGoogleTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdatePresenterAttributesVariant1VoiceGoogleTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdatePresenterAttributesVariant1VoiceGoogleType?>
    {
        /// <inheritdoc />
        public override global::G.UpdatePresenterAttributesVariant1VoiceGoogleType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdatePresenterAttributesVariant1VoiceGoogleType? existingValue,
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
                        return global::G.UpdatePresenterAttributesVariant1VoiceGoogleTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdatePresenterAttributesVariant1VoiceGoogleType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdatePresenterAttributesVariant1VoiceGoogleType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdatePresenterAttributesVariant1VoiceGoogleType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.UpdatePresenterAttributesVariant1VoiceGoogleTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
