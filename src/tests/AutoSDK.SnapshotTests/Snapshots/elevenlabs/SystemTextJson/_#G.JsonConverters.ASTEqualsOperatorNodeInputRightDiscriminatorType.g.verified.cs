//HintName: G.JsonConverters.ASTEqualsOperatorNodeInputRightDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ASTEqualsOperatorNodeInputRightDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ASTEqualsOperatorNodeInputRightDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.ASTEqualsOperatorNodeInputRightDiscriminatorType Read(
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
                        return global::G.ASTEqualsOperatorNodeInputRightDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ASTEqualsOperatorNodeInputRightDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ASTEqualsOperatorNodeInputRightDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ASTEqualsOperatorNodeInputRightDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ASTEqualsOperatorNodeInputRightDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
