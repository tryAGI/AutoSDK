//HintName: G.JsonConverters.FilterNumberTypeColumnOnCallTableOperatorNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilterNumberTypeColumnOnCallTableOperatorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FilterNumberTypeColumnOnCallTableOperator?>
    {
        /// <inheritdoc />
        public override global::G.FilterNumberTypeColumnOnCallTableOperator? Read(
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
                        return global::G.FilterNumberTypeColumnOnCallTableOperatorExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FilterNumberTypeColumnOnCallTableOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FilterNumberTypeColumnOnCallTableOperator?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FilterNumberTypeColumnOnCallTableOperator? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FilterNumberTypeColumnOnCallTableOperatorExtensions.ToValueString(value.Value));
            }
        }
    }
}
