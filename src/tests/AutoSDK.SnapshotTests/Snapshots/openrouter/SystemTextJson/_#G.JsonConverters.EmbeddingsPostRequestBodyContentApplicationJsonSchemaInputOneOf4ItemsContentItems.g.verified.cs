//HintName: G.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems Read(
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
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = default;
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0>(__rawJson, options);
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
                        embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 == null)
            {
                try
                {
                    embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0,

                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0, typeof(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0), options);
            }
            else if (value.IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1, typeof(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1), options);
            }
        }
    }
}