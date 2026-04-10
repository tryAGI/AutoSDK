//HintName: G.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListMessagesForStepResponseItemDiscriminatorMessageTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ListMessagesForStepResponseItemDiscriminatorMessageType>
    {
        /// <inheritdoc />
        public override global::G.ListMessagesForStepResponseItemDiscriminatorMessageType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ListMessagesForStepResponseItemDiscriminatorMessageType existingValue,
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
                        return global::G.ListMessagesForStepResponseItemDiscriminatorMessageTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ListMessagesForStepResponseItemDiscriminatorMessageType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ListMessagesForStepResponseItemDiscriminatorMessageType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ListMessagesForStepResponseItemDiscriminatorMessageType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ListMessagesForStepResponseItemDiscriminatorMessageTypeExtensions.ToValueString(value));
        }
    }
}
