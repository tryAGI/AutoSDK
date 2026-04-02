//HintName: G.JsonConverters.NamedVectorStruct.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class NamedVectorStructJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.NamedVectorStruct>
    {
        /// <inheritdoc />
        public override global::G.NamedVectorStruct Read(
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
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("vector")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("vector")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::System.Collections.Generic.IList<float>? namedVectorStructVariant1 = default;
            global::G.NamedVector? namedVector = default;
            global::G.NamedSparseVector? sparse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                        namedVectorStructVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NamedVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NamedVector> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NamedVector).Name}");
                        namedVector = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NamedSparseVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NamedSparseVector> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NamedSparseVector).Name}");
                        sparse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (namedVectorStructVariant1 == null && namedVector == null && sparse == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                    namedVectorStructVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NamedVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NamedVector> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NamedVector).Name}");
                    namedVector = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NamedSparseVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NamedSparseVector> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NamedSparseVector).Name}");
                    sparse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.NamedVectorStruct(
                namedVectorStructVariant1,

                namedVector,

                sparse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.NamedVectorStruct value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNamedVectorStructVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<float>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<float>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<float>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedVectorStructVariant1!, typeInfo);
            }
            else if (value.IsNamedVector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NamedVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NamedVector?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NamedVector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedVector!, typeInfo);
            }
            else if (value.IsSparse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NamedSparseVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NamedSparseVector?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NamedSparseVector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sparse!, typeInfo);
            }
        }
    }
}