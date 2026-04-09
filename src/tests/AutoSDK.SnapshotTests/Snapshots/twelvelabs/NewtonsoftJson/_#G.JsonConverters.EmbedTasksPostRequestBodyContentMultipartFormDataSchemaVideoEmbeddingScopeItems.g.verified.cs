//HintName: G.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>
    {
        /// <inheritdoc />
        public override global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems existingValue,
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
                        return global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsExtensions.ToValueString(value));
        }
    }
}
