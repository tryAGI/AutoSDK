//HintName: G.JsonConverters.ConfiguredRulesSpellingAndGrammarActivePassiveVoice.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesSpellingAndGrammarActivePassiveVoiceJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ConfiguredRulesSpellingAndGrammarActivePassiveVoice>
    {
        /// <inheritdoc />
        public override global::G.ConfiguredRulesSpellingAndGrammarActivePassiveVoice ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ConfiguredRulesSpellingAndGrammarActivePassiveVoice existingValue,
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
                        return global::G.ConfiguredRulesSpellingAndGrammarActivePassiveVoiceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ConfiguredRulesSpellingAndGrammarActivePassiveVoice)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ConfiguredRulesSpellingAndGrammarActivePassiveVoice);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ConfiguredRulesSpellingAndGrammarActivePassiveVoice value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ConfiguredRulesSpellingAndGrammarActivePassiveVoiceExtensions.ToValueString(value));
        }
    }
}
