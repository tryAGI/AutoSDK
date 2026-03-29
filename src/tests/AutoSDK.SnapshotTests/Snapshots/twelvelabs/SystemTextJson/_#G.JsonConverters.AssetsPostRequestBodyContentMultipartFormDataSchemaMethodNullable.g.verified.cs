//HintName: G.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AssetsPostRequestBodyContentMultipartFormDataSchemaMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod?>
    {
        /// <inheritdoc />
        public override global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
