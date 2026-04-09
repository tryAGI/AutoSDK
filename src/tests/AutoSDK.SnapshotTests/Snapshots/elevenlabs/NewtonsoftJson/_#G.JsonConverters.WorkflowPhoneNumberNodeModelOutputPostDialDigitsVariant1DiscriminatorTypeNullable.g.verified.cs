//HintName: G.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? existingValue,
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
                        return global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
