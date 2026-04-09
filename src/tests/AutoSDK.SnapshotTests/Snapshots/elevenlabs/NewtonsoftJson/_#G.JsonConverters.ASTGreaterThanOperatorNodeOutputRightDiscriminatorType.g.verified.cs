//HintName: G.JsonConverters.ASTGreaterThanOperatorNodeOutputRightDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ASTGreaterThanOperatorNodeOutputRightDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ASTGreaterThanOperatorNodeOutputRightDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.ASTGreaterThanOperatorNodeOutputRightDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ASTGreaterThanOperatorNodeOutputRightDiscriminatorType existingValue,
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
                        return global::G.ASTGreaterThanOperatorNodeOutputRightDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ASTGreaterThanOperatorNodeOutputRightDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ASTGreaterThanOperatorNodeOutputRightDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ASTGreaterThanOperatorNodeOutputRightDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ASTGreaterThanOperatorNodeOutputRightDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
