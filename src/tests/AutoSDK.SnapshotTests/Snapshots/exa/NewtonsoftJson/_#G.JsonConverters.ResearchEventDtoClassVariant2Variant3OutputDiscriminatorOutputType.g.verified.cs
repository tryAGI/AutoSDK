//HintName: G.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType>
    {
        /// <inheritdoc />
        public override global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType existingValue,
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
                        return global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputTypeExtensions.ToValueString(value));
        }
    }
}
