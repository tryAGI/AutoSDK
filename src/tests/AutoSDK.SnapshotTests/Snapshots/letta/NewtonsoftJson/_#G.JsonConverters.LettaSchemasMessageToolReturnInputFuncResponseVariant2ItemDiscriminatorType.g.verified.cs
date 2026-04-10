//HintName: G.JsonConverters.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType existingValue,
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
                        return global::G.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
