//HintName: G.JsonConverters.ConfiguredRulesPunctuationQuotationMarkAndApostrophe.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesPunctuationQuotationMarkAndApostropheJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ConfiguredRulesPunctuationQuotationMarkAndApostrophe>
    {
        /// <inheritdoc />
        public override global::G.ConfiguredRulesPunctuationQuotationMarkAndApostrophe ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ConfiguredRulesPunctuationQuotationMarkAndApostrophe existingValue,
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
                        return global::G.ConfiguredRulesPunctuationQuotationMarkAndApostropheExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ConfiguredRulesPunctuationQuotationMarkAndApostrophe)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ConfiguredRulesPunctuationQuotationMarkAndApostrophe);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ConfiguredRulesPunctuationQuotationMarkAndApostrophe value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ConfiguredRulesPunctuationQuotationMarkAndApostropheExtensions.ToValueString(value));
        }
    }
}
