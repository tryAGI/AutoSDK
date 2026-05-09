//HintName: G.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType>
    {
        /// <inheritdoc />
        public override global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType existingValue,
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
                        return global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputTypeExtensions.ToValueString(value));
        }
    }
}
