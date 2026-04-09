//HintName: G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnvironmentsSendMessageRequestMessageVariant1RoleNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.EnvironmentsSendMessageRequestMessageVariant1Role?>
    {
        /// <inheritdoc />
        public override global::G.EnvironmentsSendMessageRequestMessageVariant1Role? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.EnvironmentsSendMessageRequestMessageVariant1Role? existingValue,
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
                        return global::G.EnvironmentsSendMessageRequestMessageVariant1RoleExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.EnvironmentsSendMessageRequestMessageVariant1Role)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.EnvironmentsSendMessageRequestMessageVariant1Role?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.EnvironmentsSendMessageRequestMessageVariant1Role? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.EnvironmentsSendMessageRequestMessageVariant1RoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
