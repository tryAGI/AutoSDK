//HintName: G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2>
    {
        /// <inheritdoc />
        public override global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2 ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2 existingValue,
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
                        return global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2 value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2Extensions.ToValueString(value));
        }
    }
}
