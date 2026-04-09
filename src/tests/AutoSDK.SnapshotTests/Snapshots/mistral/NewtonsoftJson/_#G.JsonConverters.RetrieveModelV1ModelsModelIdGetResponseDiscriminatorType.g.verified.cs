//HintName: G.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType existingValue,
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
                        return global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
