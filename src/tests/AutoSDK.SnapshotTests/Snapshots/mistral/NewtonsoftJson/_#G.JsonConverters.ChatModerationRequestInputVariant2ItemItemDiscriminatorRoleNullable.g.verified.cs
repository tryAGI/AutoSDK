//HintName: G.JsonConverters.ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole?>
    {
        /// <inheritdoc />
        public override global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole? existingValue,
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
                        return global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
