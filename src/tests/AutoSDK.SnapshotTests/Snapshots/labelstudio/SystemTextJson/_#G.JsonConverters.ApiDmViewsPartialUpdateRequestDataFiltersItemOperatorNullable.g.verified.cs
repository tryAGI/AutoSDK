//HintName: G.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator?>
    {
        /// <inheritdoc />
        public override global::G.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator? Read(
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
                        return global::G.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorExtensions.ToValueString(value.Value));
            }
        }
    }
}
