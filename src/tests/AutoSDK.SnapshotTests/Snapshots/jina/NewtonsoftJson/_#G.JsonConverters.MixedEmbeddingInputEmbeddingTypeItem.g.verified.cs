//HintName: G.JsonConverters.MixedEmbeddingInputEmbeddingTypeItem.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MixedEmbeddingInputEmbeddingTypeItemJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MixedEmbeddingInputEmbeddingTypeItem>
    {
        /// <inheritdoc />
        public override global::G.MixedEmbeddingInputEmbeddingTypeItem ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MixedEmbeddingInputEmbeddingTypeItem existingValue,
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
                        return global::G.MixedEmbeddingInputEmbeddingTypeItemExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MixedEmbeddingInputEmbeddingTypeItem)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MixedEmbeddingInputEmbeddingTypeItem);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MixedEmbeddingInputEmbeddingTypeItem value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MixedEmbeddingInputEmbeddingTypeItemExtensions.ToValueString(value));
        }
    }
}
