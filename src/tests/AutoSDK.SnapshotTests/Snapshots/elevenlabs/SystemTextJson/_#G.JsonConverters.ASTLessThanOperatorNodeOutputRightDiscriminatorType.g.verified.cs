//HintName: G.JsonConverters.ASTLessThanOperatorNodeOutputRightDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ASTLessThanOperatorNodeOutputRightDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ASTLessThanOperatorNodeOutputRightDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.ASTLessThanOperatorNodeOutputRightDiscriminatorType Read(
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
                        return global::G.ASTLessThanOperatorNodeOutputRightDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ASTLessThanOperatorNodeOutputRightDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ASTLessThanOperatorNodeOutputRightDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ASTLessThanOperatorNodeOutputRightDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ASTLessThanOperatorNodeOutputRightDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
