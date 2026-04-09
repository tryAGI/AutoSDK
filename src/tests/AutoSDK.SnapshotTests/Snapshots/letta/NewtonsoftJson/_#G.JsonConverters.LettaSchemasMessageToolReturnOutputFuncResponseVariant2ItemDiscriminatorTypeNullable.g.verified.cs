//HintName: G.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType? existingValue,
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
                        return global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
