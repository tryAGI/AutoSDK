//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf9Content.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseMessagesResultContentItemsOneOf9ContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf9Content>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf9Content Read(
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
            if (__jsonProps.Contains("error_code")) __score0++;
            if (__jsonProps.Contains("error_message")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("file_type")) __score1++;
            if (__jsonProps.Contains("num_lines")) __score1++;
            if (__jsonProps.Contains("start_line")) __score1++;
            if (__jsonProps.Contains("total_lines")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("is_file_update")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("lines")) __score3++;
            if (__jsonProps.Contains("new_lines")) __score3++;
            if (__jsonProps.Contains("new_start")) __score3++;
            if (__jsonProps.Contains("old_lines")) __score3++;
            if (__jsonProps.Contains("old_start")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.BaseMessagesResultContentItemsOneOf9Content0? baseMessagesResultContentItemsOneOf9Content0 = default;
            global::G.BaseMessagesResultContentItemsOneOf9Content1? baseMessagesResultContentItemsOneOf9Content1 = default;
            global::G.BaseMessagesResultContentItemsOneOf9Content2? baseMessagesResultContentItemsOneOf9Content2 = default;
            global::G.BaseMessagesResultContentItemsOneOf9Content3? baseMessagesResultContentItemsOneOf9Content3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content0).Name}");
                        baseMessagesResultContentItemsOneOf9Content0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content1).Name}");
                        baseMessagesResultContentItemsOneOf9Content1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content2).Name}");
                        baseMessagesResultContentItemsOneOf9Content2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content3).Name}");
                        baseMessagesResultContentItemsOneOf9Content3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseMessagesResultContentItemsOneOf9Content0 == null && baseMessagesResultContentItemsOneOf9Content1 == null && baseMessagesResultContentItemsOneOf9Content2 == null && baseMessagesResultContentItemsOneOf9Content3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content0).Name}");
                    baseMessagesResultContentItemsOneOf9Content0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content1).Name}");
                    baseMessagesResultContentItemsOneOf9Content1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content2).Name}");
                    baseMessagesResultContentItemsOneOf9Content2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content3).Name}");
                    baseMessagesResultContentItemsOneOf9Content3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseMessagesResultContentItemsOneOf9Content(
                baseMessagesResultContentItemsOneOf9Content0,

                baseMessagesResultContentItemsOneOf9Content1,

                baseMessagesResultContentItemsOneOf9Content2,

                baseMessagesResultContentItemsOneOf9Content3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf9Content value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseMessagesResultContentItemsOneOf9Content0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf9Content0!, typeInfo);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf9Content1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf9Content1!, typeInfo);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf9Content2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf9Content2!, typeInfo);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf9Content3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf9Content3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf9Content3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf9Content3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf9Content3!, typeInfo);
            }
        }
    }
}