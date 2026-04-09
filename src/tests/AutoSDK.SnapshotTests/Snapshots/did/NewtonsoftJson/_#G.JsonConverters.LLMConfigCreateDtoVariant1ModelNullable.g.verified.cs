//HintName: G.JsonConverters.LLMConfigCreateDtoVariant1ModelNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LLMConfigCreateDtoVariant1ModelNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.LLMConfigCreateDtoVariant1Model?>
    {
        /// <inheritdoc />
        public override global::G.LLMConfigCreateDtoVariant1Model? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.LLMConfigCreateDtoVariant1Model? existingValue,
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
                        return global::G.LLMConfigCreateDtoVariant1ModelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.LLMConfigCreateDtoVariant1Model)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.LLMConfigCreateDtoVariant1Model?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.LLMConfigCreateDtoVariant1Model? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.LLMConfigCreateDtoVariant1ModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
