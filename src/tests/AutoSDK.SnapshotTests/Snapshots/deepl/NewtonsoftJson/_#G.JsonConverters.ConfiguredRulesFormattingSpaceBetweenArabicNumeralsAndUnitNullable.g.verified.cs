//HintName: G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit?>
    {
        /// <inheritdoc />
        public override global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit? existingValue,
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
                        return global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitExtensions.ToValueString(value.Value));
            }
        }
    }
}
