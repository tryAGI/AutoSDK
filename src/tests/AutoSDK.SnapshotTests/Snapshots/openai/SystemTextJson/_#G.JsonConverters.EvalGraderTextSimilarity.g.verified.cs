//HintName: G.JsonConverters.EvalGraderTextSimilarity.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EvalGraderTextSimilarityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EvalGraderTextSimilarity>
    {
        /// <inheritdoc />
        public override global::G.EvalGraderTextSimilarity Read(
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
            if (__jsonProps.Contains("evaluation_metric")) __score0++;
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("reference")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("pass_threshold")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.GraderTextSimilarity? textSimilarityGrader = default;
            global::G.EvalGraderTextSimilarityVariant2? evalGraderTextSimilarityVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        textSimilarityGrader = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraderTextSimilarity>(__rawJson, options);
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
                        evalGraderTextSimilarityVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EvalGraderTextSimilarityVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textSimilarityGrader == null && evalGraderTextSimilarityVariant2 == null)
            {
                try
                {
                    textSimilarityGrader = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GraderTextSimilarity>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    evalGraderTextSimilarityVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EvalGraderTextSimilarityVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EvalGraderTextSimilarity(
                textSimilarityGrader,

                evalGraderTextSimilarityVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EvalGraderTextSimilarity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextSimilarityGrader)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextSimilarityGrader, typeof(global::G.GraderTextSimilarity), options);
            }
            else if (value.IsEvalGraderTextSimilarityVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EvalGraderTextSimilarityVariant2, typeof(global::G.EvalGraderTextSimilarityVariant2), options);
            }
        }
    }
}