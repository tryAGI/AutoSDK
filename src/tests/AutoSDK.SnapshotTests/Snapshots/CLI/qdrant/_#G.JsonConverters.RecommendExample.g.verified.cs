//HintName: G.JsonConverters.RecommendExample.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RecommendExampleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RecommendExample>
    {
        /// <inheritdoc />
        public override global::G.RecommendExample Read(
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
            var __score1 = 0;
            var __score2 = 0;
            if (__jsonProps.Contains("indices")) __score2++;
            if (__jsonProps.Contains("values")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.ExtendedPointId? extendedPointId = default;
            global::System.Collections.Generic.IList<float>? recommendExampleVariant2 = default;
            global::G.SparseVector? sparseVector = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExtendedPointId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExtendedPointId> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExtendedPointId).Name}");
                        extendedPointId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                        recommendExampleVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SparseVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SparseVector> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SparseVector).Name}");
                        sparseVector = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (extendedPointId == null && recommendExampleVariant2 == null && sparseVector == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExtendedPointId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExtendedPointId> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExtendedPointId).Name}");
                    extendedPointId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                    recommendExampleVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SparseVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SparseVector> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SparseVector).Name}");
                    sparseVector = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RecommendExample(
                extendedPointId,

                recommendExampleVariant2,

                sparseVector
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RecommendExample value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsExtendedPointId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExtendedPointId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExtendedPointId> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExtendedPointId).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExtendedPointId!.Value, typeInfo);
            }
            else if (value.IsRecommendExampleVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RecommendExampleVariant2!, typeInfo);
            }
            else if (value.IsSparseVector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SparseVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SparseVector?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SparseVector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SparseVector!, typeInfo);
            }
        }
    }
}