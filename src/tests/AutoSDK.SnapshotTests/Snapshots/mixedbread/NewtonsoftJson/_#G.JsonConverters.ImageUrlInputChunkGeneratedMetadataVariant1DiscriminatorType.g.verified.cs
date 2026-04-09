//HintName: G.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType existingValue,
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
                        return global::G.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
