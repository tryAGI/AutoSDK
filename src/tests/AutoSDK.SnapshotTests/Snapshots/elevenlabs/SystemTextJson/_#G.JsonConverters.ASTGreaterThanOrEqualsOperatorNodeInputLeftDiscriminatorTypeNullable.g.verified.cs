//HintName: G.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::G.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType? Read(
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
                        return global::G.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
