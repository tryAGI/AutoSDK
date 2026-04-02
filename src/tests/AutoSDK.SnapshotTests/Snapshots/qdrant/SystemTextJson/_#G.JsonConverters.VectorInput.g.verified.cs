//HintName: G.JsonConverters.VectorInput.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class VectorInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.VectorInput>
    {
        /// <inheritdoc />
        public override global::G.VectorInput Read(
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
            if (__jsonProps.Contains("indices")) __score1++;
            if (__jsonProps.Contains("values")) __score1++;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            if (__jsonProps.Contains("model")) __score4++;
            if (__jsonProps.Contains("options")) __score4++;
            if (__jsonProps.Contains("text")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("image")) __score5++;
            if (__jsonProps.Contains("model")) __score5++;
            if (__jsonProps.Contains("options")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("model")) __score6++;
            if (__jsonProps.Contains("object")) __score6++;
            if (__jsonProps.Contains("options")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::System.Collections.Generic.IList<float>? vectorInputVariant1 = default;
            global::G.SparseVector? sparse = default;
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? vectorInputVariant3 = default;
            global::G.ExtendedPointId? extendedPointId = default;
            global::G.Document? document = default;
            global::G.Image? image = default;
            global::G.InferenceObject? inferenceObject = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                        vectorInputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SparseVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SparseVector> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SparseVector).Name}");
                        sparse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>).Name}");
                        vectorInputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Document), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Document> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Document).Name}");
                        document = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Image> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Image).Name}");
                        image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InferenceObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InferenceObject> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InferenceObject).Name}");
                        inferenceObject = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (vectorInputVariant1 == null && sparse == null && vectorInputVariant3 == null && extendedPointId == null && document == null && image == null && inferenceObject == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                    vectorInputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    sparse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>).Name}");
                    vectorInputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Document), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Document> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Document).Name}");
                    document = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Image> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Image).Name}");
                    image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InferenceObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InferenceObject> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InferenceObject).Name}");
                    inferenceObject = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.VectorInput(
                vectorInputVariant1,

                sparse,

                vectorInputVariant3,

                extendedPointId,

                document,

                image,

                inferenceObject
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.VectorInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVectorInputVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VectorInputVariant1!, typeInfo);
            }
            else if (value.IsSparse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SparseVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SparseVector?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SparseVector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sparse!, typeInfo);
            }
            else if (value.IsVectorInputVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VectorInputVariant3!, typeInfo);
            }
            else if (value.IsExtendedPointId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExtendedPointId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExtendedPointId> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExtendedPointId).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExtendedPointId!.Value, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Document), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Document?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Document).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Image?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Image).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsInferenceObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InferenceObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InferenceObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InferenceObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InferenceObject!, typeInfo);
            }
        }
    }
}