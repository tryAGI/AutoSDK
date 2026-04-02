//HintName: G.JsonConverters.ResponseSchemaVariant12.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseSchemaVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseSchemaVariant12>
    {
        /// <inheritdoc />
        public override global::G.ResponseSchemaVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoogleVertexModelSettingsResponseSchemaVariant1Discriminator>(ref readerCopy, options);

            global::G.TextResponseFormat? text = default;
            if (discriminator?.Type == global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextResponseFormat>(ref reader, options);
            }
            global::G.JsonSchemaResponseFormat? jsonSchema = default;
            if (discriminator?.Type == global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.JsonSchema)
            {
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize<global::G.JsonSchemaResponseFormat>(ref reader, options);
            }
            global::G.JsonObjectResponseFormat? jsonObject = default;
            if (discriminator?.Type == global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.JsonObject)
            {
                jsonObject = global::System.Text.Json.JsonSerializer.Deserialize<global::G.JsonObjectResponseFormat>(ref reader, options);
            }

            var __value = new global::G.ResponseSchemaVariant12(
                discriminator?.Type,
                text,

                jsonSchema,

                jsonObject
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseSchemaVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextResponseFormat), options);
            }
            else if (value.IsJsonSchema)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema, typeof(global::G.JsonSchemaResponseFormat), options);
            }
            else if (value.IsJsonObject)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonObject, typeof(global::G.JsonObjectResponseFormat), options);
            }
        }
    }
}