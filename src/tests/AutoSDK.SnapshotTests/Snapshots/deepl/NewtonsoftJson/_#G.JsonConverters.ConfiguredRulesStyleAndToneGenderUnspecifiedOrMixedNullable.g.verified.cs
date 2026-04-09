//HintName: G.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed?>
    {
        /// <inheritdoc />
        public override global::G.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed? existingValue,
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
                        return global::G.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedExtensions.ToValueString(value.Value));
            }
        }
    }
}
