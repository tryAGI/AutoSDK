//HintName: G.JsonConverters.ShotstackTextToSpeechOptionsLanguage.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ShotstackTextToSpeechOptionsLanguageJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ShotstackTextToSpeechOptionsLanguage>
    {
        /// <inheritdoc />
        public override global::G.ShotstackTextToSpeechOptionsLanguage ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ShotstackTextToSpeechOptionsLanguage existingValue,
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
                        return global::G.ShotstackTextToSpeechOptionsLanguageExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ShotstackTextToSpeechOptionsLanguage)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ShotstackTextToSpeechOptionsLanguage);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ShotstackTextToSpeechOptionsLanguage value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ShotstackTextToSpeechOptionsLanguageExtensions.ToValueString(value));
        }
    }
}
