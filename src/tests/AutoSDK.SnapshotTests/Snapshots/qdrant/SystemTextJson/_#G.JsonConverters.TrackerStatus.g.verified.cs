//HintName: G.JsonConverters.TrackerStatus.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TrackerStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TrackerStatus>
    {
        /// <inheritdoc />
        public override global::G.TrackerStatus Read(
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
            if (__jsonProps.Contains("cancelled")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("error")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.TrackerStatusEnum? @enum = default;
            global::G.TrackerStatusEnum2? enum2 = default;
            global::G.TrackerStatusEnum3? enum3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TrackerStatusEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TrackerStatusEnum> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TrackerStatusEnum).Name}");
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TrackerStatusEnum2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TrackerStatusEnum2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TrackerStatusEnum2).Name}");
                        enum2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TrackerStatusEnum3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TrackerStatusEnum3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TrackerStatusEnum3).Name}");
                        enum3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@enum == null && enum2 == null && enum3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TrackerStatusEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TrackerStatusEnum> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TrackerStatusEnum).Name}");
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TrackerStatusEnum2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TrackerStatusEnum2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TrackerStatusEnum2).Name}");
                    enum2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TrackerStatusEnum3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TrackerStatusEnum3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TrackerStatusEnum3).Name}");
                    enum3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TrackerStatus(
                @enum,

                enum2,

                enum3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TrackerStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEnum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TrackerStatusEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TrackerStatusEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TrackerStatusEnum).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum!.Value, typeInfo);
            }
            else if (value.IsEnum2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TrackerStatusEnum2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TrackerStatusEnum2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TrackerStatusEnum2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum2!, typeInfo);
            }
            else if (value.IsEnum3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TrackerStatusEnum3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TrackerStatusEnum3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TrackerStatusEnum3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum3!, typeInfo);
            }
        }
    }
}