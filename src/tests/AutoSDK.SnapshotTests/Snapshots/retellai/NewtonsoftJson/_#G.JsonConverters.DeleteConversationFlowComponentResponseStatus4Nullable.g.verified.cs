//HintName: G.JsonConverters.DeleteConversationFlowComponentResponseStatus4Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteConversationFlowComponentResponseStatus4NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.DeleteConversationFlowComponentResponseStatus4?>
    {
        /// <inheritdoc />
        public override global::G.DeleteConversationFlowComponentResponseStatus4? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.DeleteConversationFlowComponentResponseStatus4? existingValue,
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
                        return global::G.DeleteConversationFlowComponentResponseStatus4Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.DeleteConversationFlowComponentResponseStatus4)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.DeleteConversationFlowComponentResponseStatus4?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.DeleteConversationFlowComponentResponseStatus4? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.DeleteConversationFlowComponentResponseStatus4Extensions.ToValueString(value.Value));
            }
        }
    }
}
