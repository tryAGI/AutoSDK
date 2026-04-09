//HintName: G.JsonConverters.LlamaParseParametersImagesToSaveVariant1Item.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LlamaParseParametersImagesToSaveVariant1ItemJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.LlamaParseParametersImagesToSaveVariant1Item>
    {
        /// <inheritdoc />
        public override global::G.LlamaParseParametersImagesToSaveVariant1Item ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.LlamaParseParametersImagesToSaveVariant1Item existingValue,
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
                        return global::G.LlamaParseParametersImagesToSaveVariant1ItemExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.LlamaParseParametersImagesToSaveVariant1Item)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.LlamaParseParametersImagesToSaveVariant1Item);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.LlamaParseParametersImagesToSaveVariant1Item value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.LlamaParseParametersImagesToSaveVariant1ItemExtensions.ToValueString(value));
        }
    }
}
