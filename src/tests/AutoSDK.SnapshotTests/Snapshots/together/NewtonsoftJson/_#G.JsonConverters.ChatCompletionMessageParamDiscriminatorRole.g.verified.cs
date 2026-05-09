//HintName: G.JsonConverters.ChatCompletionMessageParamDiscriminatorRole.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionMessageParamDiscriminatorRoleJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ChatCompletionMessageParamDiscriminatorRole>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionMessageParamDiscriminatorRole ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ChatCompletionMessageParamDiscriminatorRole existingValue,
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
                        return global::G.ChatCompletionMessageParamDiscriminatorRoleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ChatCompletionMessageParamDiscriminatorRole)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ChatCompletionMessageParamDiscriminatorRole);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ChatCompletionMessageParamDiscriminatorRole value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ChatCompletionMessageParamDiscriminatorRoleExtensions.ToValueString(value));
        }
    }
}
