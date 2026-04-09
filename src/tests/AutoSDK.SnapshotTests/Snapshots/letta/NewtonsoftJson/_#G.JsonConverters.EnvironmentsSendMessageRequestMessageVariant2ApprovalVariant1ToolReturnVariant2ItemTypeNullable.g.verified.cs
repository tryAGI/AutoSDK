//HintName: G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType?>
    {
        /// <inheritdoc />
        public override global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType? existingValue,
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
                        return global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
