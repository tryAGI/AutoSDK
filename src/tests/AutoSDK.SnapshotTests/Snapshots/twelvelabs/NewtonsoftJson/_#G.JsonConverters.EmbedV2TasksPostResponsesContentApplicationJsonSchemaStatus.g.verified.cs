//HintName: G.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus>
    {
        /// <inheritdoc />
        public override global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus existingValue,
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
                        return global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusExtensions.ToValueString(value));
        }
    }
}
