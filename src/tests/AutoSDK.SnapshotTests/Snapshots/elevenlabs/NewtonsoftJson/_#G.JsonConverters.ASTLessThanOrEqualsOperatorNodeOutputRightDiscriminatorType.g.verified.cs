//HintName: G.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType existingValue,
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
                        return global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
