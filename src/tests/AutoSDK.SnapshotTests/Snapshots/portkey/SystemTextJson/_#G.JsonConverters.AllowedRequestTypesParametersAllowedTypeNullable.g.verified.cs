//HintName: G.JsonConverters.AllowedRequestTypesParametersAllowedTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AllowedRequestTypesParametersAllowedTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AllowedRequestTypesParametersAllowedType?>
    {
        /// <inheritdoc />
        public override global::G.AllowedRequestTypesParametersAllowedType? Read(
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
                        return global::G.AllowedRequestTypesParametersAllowedTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AllowedRequestTypesParametersAllowedType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AllowedRequestTypesParametersAllowedType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AllowedRequestTypesParametersAllowedType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.AllowedRequestTypesParametersAllowedTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
