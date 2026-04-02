//HintName: G.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput Read(
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
            var __score3 = 0;
            var __score4 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            string? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 = default;
            global::System.Collections.Generic.IList<string>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 = default;
            global::System.Collections.Generic.IList<double>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 = default;
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 = default;
            global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<string>>(__rawJson, options);
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

                        embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<double>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 == null)
            {
                try
                {

                    embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<string>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<double>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput(
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1,

                embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2,

                embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3,

                embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4,

                embeddingsPostRequestBodyContentApplicationJsonSchemaInput4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1, typeof(string), options);
            }
            else if (value.IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2, typeof(global::System.Collections.Generic.IList<string>), options);
            }
            else if (value.IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3, typeof(global::System.Collections.Generic.IList<double>), options);
            }
            else if (value.IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4, typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>), options);
            }
            else if (value.IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4, typeof(global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>), options);
            }
        }
    }
}