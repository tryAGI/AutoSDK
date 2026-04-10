//HintName: G.JsonConverters.CreateTranslationResponseDtoTranslationTranscriptionVersion.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTranslationResponseDtoTranslationTranscriptionVersionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateTranslationResponseDtoTranslationTranscriptionVersion>
    {
        /// <inheritdoc />
        public override global::G.CreateTranslationResponseDtoTranslationTranscriptionVersion ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateTranslationResponseDtoTranslationTranscriptionVersion existingValue,
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
                        return global::G.CreateTranslationResponseDtoTranslationTranscriptionVersionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateTranslationResponseDtoTranslationTranscriptionVersion)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateTranslationResponseDtoTranslationTranscriptionVersion);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateTranslationResponseDtoTranslationTranscriptionVersion value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateTranslationResponseDtoTranslationTranscriptionVersionExtensions.ToValueString(value));
        }
    }
}
