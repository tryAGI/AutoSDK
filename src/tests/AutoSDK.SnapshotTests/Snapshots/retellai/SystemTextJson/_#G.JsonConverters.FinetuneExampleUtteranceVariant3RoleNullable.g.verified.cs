//HintName: G.JsonConverters.FinetuneExampleUtteranceVariant3RoleNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FinetuneExampleUtteranceVariant3RoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FinetuneExampleUtteranceVariant3Role?>
    {
        /// <inheritdoc />
        public override global::G.FinetuneExampleUtteranceVariant3Role? Read(
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
                        return global::G.FinetuneExampleUtteranceVariant3RoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FinetuneExampleUtteranceVariant3Role)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FinetuneExampleUtteranceVariant3Role?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FinetuneExampleUtteranceVariant3Role? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FinetuneExampleUtteranceVariant3RoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
