//HintName: G.JsonConverters.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirectionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection?>
    {
        /// <inheritdoc />
        public override global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection? Read(
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
                        return global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirectionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
