//HintName: G.JsonConverters.ReturnChatGroupPagedChatsPaginationDirection.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReturnChatGroupPagedChatsPaginationDirectionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ReturnChatGroupPagedChatsPaginationDirection>
    {
        /// <inheritdoc />
        public override global::G.ReturnChatGroupPagedChatsPaginationDirection ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ReturnChatGroupPagedChatsPaginationDirection existingValue,
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
                        return global::G.ReturnChatGroupPagedChatsPaginationDirectionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ReturnChatGroupPagedChatsPaginationDirection)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ReturnChatGroupPagedChatsPaginationDirection);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ReturnChatGroupPagedChatsPaginationDirection value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ReturnChatGroupPagedChatsPaginationDirectionExtensions.ToValueString(value));
        }
    }
}
