//HintName: G.JsonConverters.VectorStruct.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class VectorStructJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.VectorStruct>
    {
        /// <inheritdoc />
        public override global::G.VectorStruct Read(
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
            var __score3 = 0;
            if (__jsonProps.Contains("model")) __score3++;
            if (__jsonProps.Contains("options")) __score3++;
            if (__jsonProps.Contains("text")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("image")) __score4++;
            if (__jsonProps.Contains("model")) __score4++;
            if (__jsonProps.Contains("options")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("model")) __score5++;
            if (__jsonProps.Contains("object")) __score5++;
            if (__jsonProps.Contains("options")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::System.Collections.Generic.IList<float>? vectorStructVariant1 = default;
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? vectorStructVariant2 = default;
            object? vectorStructVariant3 = default;
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
                        vectorStructVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>).Name}");
                        vectorStructVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        vectorStructVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 4)
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
                else if (__bestIndex == 5)
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

            if (vectorStructVariant1 == null && vectorStructVariant2 == null && vectorStructVariant3 == null && document == null && image == null && inferenceObject == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                    vectorStructVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    vectorStructVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    vectorStructVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::G.VectorStruct(
                vectorStructVariant1,

                vectorStructVariant2,

                vectorStructVariant3,

                document,

                image,

                inferenceObject
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.VectorStruct value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVectorStructVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VectorStructVariant1!, typeInfo);
            }
            else if (value.IsVectorStructVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VectorStructVariant2!, typeInfo);
            }
            else if (value.IsVectorStructVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VectorStructVariant3!, typeInfo);
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