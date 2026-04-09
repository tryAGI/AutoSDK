//HintName: G.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType existingValue,
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
                        return global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
