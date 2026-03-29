//HintName: G.JsonConverters.QuantizationConfigDiff.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class QuantizationConfigDiffJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.QuantizationConfigDiff>
    {
        /// <inheritdoc />
        public override global::G.QuantizationConfigDiff Read(
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
            if (__jsonProps.Contains("scalar")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("product")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("binary")) __score2++;
            var __score3 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.ScalarQuantization? scalar = default;
            global::G.ProductQuantization? product = default;
            global::G.BinaryQuantization? binary = default;
            global::G.DisabledType? disabledType = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ScalarQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ScalarQuantization> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ScalarQuantization).Name}");
                        scalar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ProductQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ProductQuantization> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ProductQuantization).Name}");
                        product = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BinaryQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BinaryQuantization> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BinaryQuantization).Name}");
                        binary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DisabledType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DisabledType> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DisabledType).Name}");
                        disabledType = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (scalar == null && product == null && binary == null && disabledType == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ScalarQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ScalarQuantization> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ScalarQuantization).Name}");
                    scalar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ProductQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ProductQuantization> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ProductQuantization).Name}");
                    product = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BinaryQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BinaryQuantization> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BinaryQuantization).Name}");
                    binary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DisabledType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DisabledType> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DisabledType).Name}");
                    disabledType = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.QuantizationConfigDiff(
                scalar,

                product,

                binary,

                disabledType
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.QuantizationConfigDiff value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsScalar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ScalarQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ScalarQuantization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ScalarQuantization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Scalar, typeInfo);
            }
            else if (value.IsProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ProductQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ProductQuantization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ProductQuantization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Product, typeInfo);
            }
            else if (value.IsBinary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BinaryQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BinaryQuantization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BinaryQuantization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Binary, typeInfo);
            }
            else if (value.IsDisabledType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DisabledType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DisabledType> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DisabledType).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DisabledType, typeInfo);
            }
        }
    }
}