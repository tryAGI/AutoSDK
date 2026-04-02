//HintName: G.JsonConverters.PayloadStorageType.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PayloadStorageTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PayloadStorageType>
    {
        /// <inheritdoc />
        public override global::G.PayloadStorageType Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.PayloadStorageTypeVariant1? payloadStorageTypeVariant1 = default;
            global::G.PayloadStorageTypeVariant2? payloadStorageTypeVariant2 = default;
            global::G.PayloadStorageTypeVariant3? payloadStorageTypeVariant3 = default;
            global::G.PayloadStorageTypeVariant4? payloadStorageTypeVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant1).Name}");
                        payloadStorageTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant2).Name}");
                        payloadStorageTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant3).Name}");
                        payloadStorageTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant4).Name}");
                        payloadStorageTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (payloadStorageTypeVariant1 == null && payloadStorageTypeVariant2 == null && payloadStorageTypeVariant3 == null && payloadStorageTypeVariant4 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant1).Name}");
                    payloadStorageTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant2).Name}");
                    payloadStorageTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant3).Name}");
                    payloadStorageTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant4).Name}");
                    payloadStorageTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.PayloadStorageType(
                payloadStorageTypeVariant1,

                payloadStorageTypeVariant2,

                payloadStorageTypeVariant3,

                payloadStorageTypeVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PayloadStorageType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPayloadStorageTypeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PayloadStorageTypeVariant1!, typeInfo);
            }
            else if (value.IsPayloadStorageTypeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PayloadStorageTypeVariant2!, typeInfo);
            }
            else if (value.IsPayloadStorageTypeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PayloadStorageTypeVariant3!, typeInfo);
            }
            else if (value.IsPayloadStorageTypeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PayloadStorageTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PayloadStorageTypeVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PayloadStorageTypeVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PayloadStorageTypeVariant4!, typeInfo);
            }
        }
    }
}