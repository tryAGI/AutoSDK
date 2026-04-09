//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf5Content.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseMessagesResultContentItemsOneOf5ContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf5Content>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf5Content Read(
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
            if (__jsonProps.Contains("error_code")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>? baseMessagesResultContentItemsOneOf5Content0 = default;
            global::G.BaseMessagesResultContentItemsOneOf5Content1? baseMessagesResultContentItemsOneOf5Content1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>).Name}");
                        baseMessagesResultContentItemsOneOf5Content0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf5Content1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf5Content1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf5Content1).Name}");
                        baseMessagesResultContentItemsOneOf5Content1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseMessagesResultContentItemsOneOf5Content0 == null && baseMessagesResultContentItemsOneOf5Content1 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>).Name}");
                    baseMessagesResultContentItemsOneOf5Content0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf5Content1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf5Content1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf5Content1).Name}");
                    baseMessagesResultContentItemsOneOf5Content1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseMessagesResultContentItemsOneOf5Content(
                baseMessagesResultContentItemsOneOf5Content0,

                baseMessagesResultContentItemsOneOf5Content1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf5Content value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseMessagesResultContentItemsOneOf5Content0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf5Content0!, typeInfo);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf5Content1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseMessagesResultContentItemsOneOf5Content1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseMessagesResultContentItemsOneOf5Content1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseMessagesResultContentItemsOneOf5Content1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf5Content1!, typeInfo);
            }
        }
    }
}