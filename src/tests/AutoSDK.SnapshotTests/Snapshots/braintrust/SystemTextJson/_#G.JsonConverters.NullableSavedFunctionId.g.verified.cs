//HintName: G.JsonConverters.NullableSavedFunctionId.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class NullableSavedFunctionIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.NullableSavedFunctionId>
    {
        /// <inheritdoc />
        public override global::G.NullableSavedFunctionId Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("function_type")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.NullableSavedFunctionIdFunction? function = default;
            global::G.NullableSavedFunctionIdGlobal? global = default;
            object? nullableSavedFunctionIdVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.NullableSavedFunctionIdFunction>(__rawJson, options);
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
                        global = global::System.Text.Json.JsonSerializer.Deserialize<global::G.NullableSavedFunctionIdGlobal>(__rawJson, options);
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
                        nullableSavedFunctionIdVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (function == null && global == null && nullableSavedFunctionIdVariant3 == null)
            {
                try
                {
                    function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.NullableSavedFunctionIdFunction>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    global = global::System.Text.Json.JsonSerializer.Deserialize<global::G.NullableSavedFunctionIdGlobal>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    nullableSavedFunctionIdVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.NullableSavedFunctionId(
                function,

                global,

                nullableSavedFunctionIdVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.NullableSavedFunctionId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.NullableSavedFunctionIdFunction), options);
            }
            else if (value.IsGlobal)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Global, typeof(global::G.NullableSavedFunctionIdGlobal), options);
            }
            else if (value.IsNullableSavedFunctionIdVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NullableSavedFunctionIdVariant3, typeof(object), options);
            }
        }
    }
}