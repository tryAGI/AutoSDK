//HintName: G.JsonConverters.CodeInterpreterServerToolContainerOneOf1MemoryLimitNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeInterpreterServerToolContainerOneOf1MemoryLimitNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit?>
    {
        /// <inheritdoc />
        public override global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit? Read(
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
                        return global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimitExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimitExtensions.ToValueString(value.Value));
            }
        }
    }
}
