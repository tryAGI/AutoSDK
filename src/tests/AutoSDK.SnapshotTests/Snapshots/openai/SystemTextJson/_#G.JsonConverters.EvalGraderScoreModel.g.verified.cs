//HintName: G.JsonConverters.EvalGraderScoreModel.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EvalGraderScoreModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EvalGraderScoreModel>
    {
        /// <inheritdoc />
        public override global::G.EvalGraderScoreModel Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("range")) __score0++;
            if (__jsonProps.Contains("sampling_params")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("pass_threshold")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.GraderScoreModel? scoreModelGrader = default;
            global::G.EvalGraderScoreModelVariant2? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderScoreModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderScoreModel> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderScoreModel).Name}");
                        scoreModelGrader = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalGraderScoreModelVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalGraderScoreModelVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalGraderScoreModelVariant2).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (scoreModelGrader == null && value2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderScoreModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderScoreModel> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderScoreModel).Name}");
                    scoreModelGrader = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalGraderScoreModelVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalGraderScoreModelVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalGraderScoreModelVariant2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EvalGraderScoreModel(
                scoreModelGrader,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EvalGraderScoreModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsScoreModelGrader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderScoreModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderScoreModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderScoreModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreModelGrader!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalGraderScoreModelVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalGraderScoreModelVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalGraderScoreModelVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
        }
    }
}