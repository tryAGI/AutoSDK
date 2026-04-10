//HintName: G.JsonConverters.ChatWebSearchShorthandParametersSearchContextSize.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatWebSearchShorthandParametersSearchContextSizeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ChatWebSearchShorthandParametersSearchContextSize>
    {
        /// <inheritdoc />
        public override global::G.ChatWebSearchShorthandParametersSearchContextSize ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ChatWebSearchShorthandParametersSearchContextSize existingValue,
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
                        return global::G.ChatWebSearchShorthandParametersSearchContextSizeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ChatWebSearchShorthandParametersSearchContextSize)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ChatWebSearchShorthandParametersSearchContextSize);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ChatWebSearchShorthandParametersSearchContextSize value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ChatWebSearchShorthandParametersSearchContextSizeExtensions.ToValueString(value));
        }
    }
}
