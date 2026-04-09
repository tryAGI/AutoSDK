//HintName: G.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType existingValue,
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
                        return global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
