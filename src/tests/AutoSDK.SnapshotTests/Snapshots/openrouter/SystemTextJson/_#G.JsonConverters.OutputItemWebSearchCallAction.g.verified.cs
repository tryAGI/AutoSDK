//HintName: G.JsonConverters.OutputItemWebSearchCallAction.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemWebSearchCallActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputItemWebSearchCallAction>
    {
        /// <inheritdoc />
        public override global::G.OutputItemWebSearchCallAction Read(
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
            if (__jsonProps.Contains("queries")) __score0++;
            if (__jsonProps.Contains("query")) __score0++;
            if (__jsonProps.Contains("sources")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("pattern")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("url")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.OutputItemWebSearchCallAction0? outputItemWebSearchCallAction0 = default;
            global::G.OutputItemWebSearchCallAction1? outputItemWebSearchCallAction1 = default;
            global::G.OutputItemWebSearchCallAction2? outputItemWebSearchCallAction2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCallAction0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCallAction0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCallAction0).Name}");
                        outputItemWebSearchCallAction0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCallAction1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCallAction1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCallAction1).Name}");
                        outputItemWebSearchCallAction1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCallAction2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCallAction2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCallAction2).Name}");
                        outputItemWebSearchCallAction2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputItemWebSearchCallAction0 == null && outputItemWebSearchCallAction1 == null && outputItemWebSearchCallAction2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCallAction0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCallAction0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCallAction0).Name}");
                    outputItemWebSearchCallAction0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCallAction1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCallAction1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCallAction1).Name}");
                    outputItemWebSearchCallAction1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCallAction2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCallAction2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCallAction2).Name}");
                    outputItemWebSearchCallAction2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OutputItemWebSearchCallAction(
                outputItemWebSearchCallAction0,

                outputItemWebSearchCallAction1,

                outputItemWebSearchCallAction2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputItemWebSearchCallAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOutputItemWebSearchCallAction0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCallAction0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCallAction0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCallAction0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemWebSearchCallAction0, typeInfo);
            }
            else if (value.IsOutputItemWebSearchCallAction1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCallAction1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCallAction1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCallAction1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemWebSearchCallAction1, typeInfo);
            }
            else if (value.IsOutputItemWebSearchCallAction2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCallAction2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCallAction2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCallAction2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemWebSearchCallAction2, typeInfo);
            }
        }
    }
}