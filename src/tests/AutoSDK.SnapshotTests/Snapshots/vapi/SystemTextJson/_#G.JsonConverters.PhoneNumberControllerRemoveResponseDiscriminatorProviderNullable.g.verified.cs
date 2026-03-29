//HintName: G.JsonConverters.PhoneNumberControllerRemoveResponseDiscriminatorProviderNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PhoneNumberControllerRemoveResponseDiscriminatorProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider?>
    {
        /// <inheritdoc />
        public override global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider? Read(
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
                        return global::G.PhoneNumberControllerRemoveResponseDiscriminatorProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PhoneNumberControllerRemoveResponseDiscriminatorProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
