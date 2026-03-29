//HintName: G.JsonConverters.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations>
    {
        /// <inheritdoc />
        public override global::G.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations Read(
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
                        return global::G.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsExtensions.ToValueString(value));
        }
    }
}
