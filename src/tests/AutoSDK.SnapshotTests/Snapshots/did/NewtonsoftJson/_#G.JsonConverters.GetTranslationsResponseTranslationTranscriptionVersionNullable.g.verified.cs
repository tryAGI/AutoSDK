//HintName: G.JsonConverters.GetTranslationsResponseTranslationTranscriptionVersionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTranslationsResponseTranslationTranscriptionVersionNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetTranslationsResponseTranslationTranscriptionVersion?>
    {
        /// <inheritdoc />
        public override global::G.GetTranslationsResponseTranslationTranscriptionVersion? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetTranslationsResponseTranslationTranscriptionVersion? existingValue,
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
                        return global::G.GetTranslationsResponseTranslationTranscriptionVersionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetTranslationsResponseTranslationTranscriptionVersion)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetTranslationsResponseTranslationTranscriptionVersion?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetTranslationsResponseTranslationTranscriptionVersion? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.GetTranslationsResponseTranslationTranscriptionVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
