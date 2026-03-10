//HintName: G.JsonConverters.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::G.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType? Read(
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
                        return global::G.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
