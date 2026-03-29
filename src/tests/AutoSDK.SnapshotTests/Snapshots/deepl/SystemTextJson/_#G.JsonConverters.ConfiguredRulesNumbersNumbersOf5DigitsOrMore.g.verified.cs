//HintName: G.JsonConverters.ConfiguredRulesNumbersNumbersOf5DigitsOrMore.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesNumbersNumbersOf5DigitsOrMoreJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConfiguredRulesNumbersNumbersOf5DigitsOrMore>
    {
        /// <inheritdoc />
        public override global::G.ConfiguredRulesNumbersNumbersOf5DigitsOrMore Read(
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
                        return global::G.ConfiguredRulesNumbersNumbersOf5DigitsOrMoreExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConfiguredRulesNumbersNumbersOf5DigitsOrMore)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConfiguredRulesNumbersNumbersOf5DigitsOrMore);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConfiguredRulesNumbersNumbersOf5DigitsOrMore value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ConfiguredRulesNumbersNumbersOf5DigitsOrMoreExtensions.ToValueString(value));
        }
    }
}
