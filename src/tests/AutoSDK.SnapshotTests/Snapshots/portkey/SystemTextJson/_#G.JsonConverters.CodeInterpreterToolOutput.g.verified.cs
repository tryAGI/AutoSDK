//HintName: G.JsonConverters.CodeInterpreterToolOutput.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CodeInterpreterToolOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeInterpreterToolOutput>
    {
        /// <inheritdoc />
        public override global::G.CodeInterpreterToolOutput Read(
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
            if (__jsonProps.Contains("logs")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("files")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.CodeInterpreterTextOutput? codeInterpreterTextOutput = default;
            global::G.CodeInterpreterFileOutput? codeInterpreterFileOutput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterTextOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterTextOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterTextOutput).Name}");
                        codeInterpreterTextOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterFileOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterFileOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterFileOutput).Name}");
                        codeInterpreterFileOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (codeInterpreterTextOutput == null && codeInterpreterFileOutput == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterTextOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterTextOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterTextOutput).Name}");
                    codeInterpreterTextOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterFileOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterFileOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterFileOutput).Name}");
                    codeInterpreterFileOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CodeInterpreterToolOutput(
                codeInterpreterTextOutput,

                codeInterpreterFileOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeInterpreterToolOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCodeInterpreterTextOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterTextOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterTextOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterTextOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterTextOutput, typeInfo);
            }
            else if (value.IsCodeInterpreterFileOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterFileOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterFileOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterFileOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterFileOutput, typeInfo);
            }
        }
    }
}