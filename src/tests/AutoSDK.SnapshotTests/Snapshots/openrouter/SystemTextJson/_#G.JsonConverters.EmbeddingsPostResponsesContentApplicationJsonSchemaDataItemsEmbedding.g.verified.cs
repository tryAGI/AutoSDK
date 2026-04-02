//HintName: G.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::System.Collections.Generic.IList<double>? embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 = default;
            string? embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<double>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 == null && embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 == null)
            {
                try
                {

                    embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<double>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding(
                embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1,

                embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1, typeof(global::System.Collections.Generic.IList<double>), options);
            }
            else if (value.IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2, typeof(string), options);
            }
        }
    }
}