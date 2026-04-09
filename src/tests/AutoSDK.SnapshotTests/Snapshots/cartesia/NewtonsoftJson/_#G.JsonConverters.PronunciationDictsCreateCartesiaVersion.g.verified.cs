//HintName: G.JsonConverters.PronunciationDictsCreateCartesiaVersion.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PronunciationDictsCreateCartesiaVersionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PronunciationDictsCreateCartesiaVersion>
    {
        /// <inheritdoc />
        public override global::G.PronunciationDictsCreateCartesiaVersion ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PronunciationDictsCreateCartesiaVersion existingValue,
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
                        return global::G.PronunciationDictsCreateCartesiaVersionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PronunciationDictsCreateCartesiaVersion)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PronunciationDictsCreateCartesiaVersion);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PronunciationDictsCreateCartesiaVersion value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PronunciationDictsCreateCartesiaVersionExtensions.ToValueString(value));
        }
    }
}
