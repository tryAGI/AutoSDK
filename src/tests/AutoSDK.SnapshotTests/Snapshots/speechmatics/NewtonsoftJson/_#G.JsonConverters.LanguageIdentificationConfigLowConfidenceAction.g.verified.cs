//HintName: G.JsonConverters.LanguageIdentificationConfigLowConfidenceAction.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LanguageIdentificationConfigLowConfidenceActionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.LanguageIdentificationConfigLowConfidenceAction>
    {
        /// <inheritdoc />
        public override global::G.LanguageIdentificationConfigLowConfidenceAction ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.LanguageIdentificationConfigLowConfidenceAction existingValue,
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
                        return global::G.LanguageIdentificationConfigLowConfidenceActionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.LanguageIdentificationConfigLowConfidenceAction)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.LanguageIdentificationConfigLowConfidenceAction);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.LanguageIdentificationConfigLowConfidenceAction value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.LanguageIdentificationConfigLowConfidenceActionExtensions.ToValueString(value));
        }
    }
}
