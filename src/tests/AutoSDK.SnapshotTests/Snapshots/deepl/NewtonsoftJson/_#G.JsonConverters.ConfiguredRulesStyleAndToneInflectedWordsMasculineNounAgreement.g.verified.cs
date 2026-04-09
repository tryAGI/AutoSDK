//HintName: G.JsonConverters.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreementJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement>
    {
        /// <inheritdoc />
        public override global::G.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement existingValue,
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
                        return global::G.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreementExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreementExtensions.ToValueString(value));
        }
    }
}
