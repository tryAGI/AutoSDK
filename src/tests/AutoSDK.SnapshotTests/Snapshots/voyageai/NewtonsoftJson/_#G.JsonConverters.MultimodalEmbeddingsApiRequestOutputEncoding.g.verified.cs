//HintName: G.JsonConverters.MultimodalEmbeddingsApiRequestOutputEncoding.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MultimodalEmbeddingsApiRequestOutputEncodingJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MultimodalEmbeddingsApiRequestOutputEncoding>
    {
        /// <inheritdoc />
        public override global::G.MultimodalEmbeddingsApiRequestOutputEncoding ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MultimodalEmbeddingsApiRequestOutputEncoding existingValue,
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
                        return global::G.MultimodalEmbeddingsApiRequestOutputEncodingExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MultimodalEmbeddingsApiRequestOutputEncoding)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MultimodalEmbeddingsApiRequestOutputEncoding);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MultimodalEmbeddingsApiRequestOutputEncoding value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MultimodalEmbeddingsApiRequestOutputEncodingExtensions.ToValueString(value));
        }
    }
}
