//HintName: G.JsonConverters.UltravoxV1BaseToolDefinitionDefaultReaction.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UltravoxV1BaseToolDefinitionDefaultReactionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UltravoxV1BaseToolDefinitionDefaultReaction>
    {
        /// <inheritdoc />
        public override global::G.UltravoxV1BaseToolDefinitionDefaultReaction ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UltravoxV1BaseToolDefinitionDefaultReaction existingValue,
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
                        return global::G.UltravoxV1BaseToolDefinitionDefaultReactionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UltravoxV1BaseToolDefinitionDefaultReaction)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UltravoxV1BaseToolDefinitionDefaultReaction);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UltravoxV1BaseToolDefinitionDefaultReaction value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UltravoxV1BaseToolDefinitionDefaultReactionExtensions.ToValueString(value));
        }
    }
}
