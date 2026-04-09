//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf7Content.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseMessagesResultContentItemsOneOf7ContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf7Content>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf7Content Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("return_code")) __score1++;
            if (__jsonProps.Contains("stderr")) __score1++;
            if (__jsonProps.Contains("stdout")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("encrypted_stdout")) __score2++;
            if (__jsonProps.Contains("return_code")) __score2++;
            if (__jsonProps.Contains("stderr")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.BaseMessagesResultContentItemsOneOf7Content0? baseMessagesResultContentItemsOneOf7Content0 = default;
            global::G.BaseMessagesResultContentItemsOneOf7Content1? baseMessagesResultContentItemsOneOf7Content1 = default;
            global::G.BaseMessagesResultContentItemsOneOf7Content2? baseMessagesResultContentItemsOneOf7Content2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf7Content0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf7Content0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf7Content0).Name}");
                        baseMessagesResultContentItemsOneOf7Content0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf7Content1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf7Content1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf7Content1).Name}");
                        baseMessagesResultContentItemsOneOf7Content1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf7Content2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf7Content2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf7Content2).Name}");
                        baseMessagesResultContentItemsOneOf7Content2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseMessagesResultContentItemsOneOf7Content0 == null && baseMessagesResultContentItemsOneOf7Content1 == null && baseMessagesResultContentItemsOneOf7Content2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf7Content0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf7Content0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf7Content0).Name}");
                    baseMessagesResultContentItemsOneOf7Content0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf7Content1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf7Content1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf7Content1).Name}");
                    baseMessagesResultContentItemsOneOf7Content1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf7Content2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf7Content2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf7Content2).Name}");
                    baseMessagesResultContentItemsOneOf7Content2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseMessagesResultContentItemsOneOf7Content(
                baseMessagesResultContentItemsOneOf7Content0,

                baseMessagesResultContentItemsOneOf7Content1,

                baseMessagesResultContentItemsOneOf7Content2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf7Content value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseMessagesResultContentItemsOneOf7Content0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf7Content0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf7Content0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf7Content0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf7Content0!, typeInfo);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf7Content1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf7Content1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf7Content1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf7Content1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf7Content1!, typeInfo);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf7Content2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf7Content2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf7Content2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf7Content2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf7Content2!, typeInfo);
            }
        }
    }
}