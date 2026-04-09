//HintName: G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchPostRequestBodyContentMultipartFormDataSchemaOperatorNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperator?>
    {
        /// <inheritdoc />
        public override global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? existingValue,
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
                        return global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperator)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperator?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorExtensions.ToValueString(value.Value));
            }
        }
    }
}
