//HintName: G.JsonConverters.EmbeddingItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingItem>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingItem Read(
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
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::System.Collections.Generic.IList<double>? embeddingItemVariant1 = default;
            global::System.Collections.Generic.IList<int>? embeddingItemVariant2 = default;
            string? embeddingItemVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        embeddingItemVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<double>>(__rawJson, options);
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

                        embeddingItemVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<int>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        embeddingItemVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (embeddingItemVariant1 == null && embeddingItemVariant2 == null && embeddingItemVariant3 == null)
            {
                try
                {

                    embeddingItemVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<double>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    embeddingItemVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<int>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    embeddingItemVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EmbeddingItem(
                embeddingItemVariant1,

                embeddingItemVariant2,

                embeddingItemVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbeddingItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEmbeddingItemVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingItemVariant1, typeof(global::System.Collections.Generic.IList<double>), options);
            }
            else if (value.IsEmbeddingItemVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingItemVariant2, typeof(global::System.Collections.Generic.IList<int>), options);
            }
            else if (value.IsEmbeddingItemVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingItemVariant3, typeof(string), options);
            }
        }
    }
}