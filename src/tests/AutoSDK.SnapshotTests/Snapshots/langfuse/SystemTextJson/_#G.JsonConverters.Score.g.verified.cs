//HintName: G.JsonConverters.Score.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ScoreJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Score>
    {
        /// <inheritdoc />
        public override global::G.Score Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>? scoreVariant1 = default;
            global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>? scoreVariant2 = default;
            global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>? scoreVariant3 = default;
            global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>? scoreVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>).Name}");
                        scoreVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>).Name}");
                        scoreVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>).Name}");
                        scoreVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>).Name}");
                        scoreVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (scoreVariant1 == null && scoreVariant2 == null && scoreVariant3 == null && scoreVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>).Name}");
                    scoreVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>).Name}");
                    scoreVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>).Name}");
                    scoreVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>).Name}");
                    scoreVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Score(
                scoreVariant1,

                scoreVariant2,

                scoreVariant3,

                scoreVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Score value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsScoreVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreVariant1!.Value, typeInfo);
            }
            else if (value.IsScoreVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreVariant2!.Value, typeInfo);
            }
            else if (value.IsScoreVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreVariant3!.Value, typeInfo);
            }
            else if (value.IsScoreVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreVariant4!.Value, typeInfo);
            }
        }
    }
}