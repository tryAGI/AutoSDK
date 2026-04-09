//HintName: G.JsonConverters.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ASTNotEqualsOperatorNodeOutputLeftDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType existingValue,
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
                        return global::G.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
