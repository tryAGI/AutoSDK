//HintName: G.JsonConverters.ResultPrompt2025ArrayString.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResultPrompt2025ArrayStringJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResultPrompt2025ArrayString>
    {
        /// <inheritdoc />
        public override global::G.ResultPrompt2025ArrayString Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("error")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("error")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ResultSuccessPrompt2025Array? success = default;
            global::G.ResultErrorString? error = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultSuccessPrompt2025Array), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultSuccessPrompt2025Array> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultSuccessPrompt2025Array).Name}");
                        success = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultErrorString), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultErrorString> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultErrorString).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (success == null && error == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultSuccessPrompt2025Array), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultSuccessPrompt2025Array> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultSuccessPrompt2025Array).Name}");
                    success = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultErrorString), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultErrorString> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultErrorString).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ResultPrompt2025ArrayString(
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResultPrompt2025ArrayString value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultSuccessPrompt2025Array), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultSuccessPrompt2025Array?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultSuccessPrompt2025Array).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultErrorString), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultErrorString?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultErrorString).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}