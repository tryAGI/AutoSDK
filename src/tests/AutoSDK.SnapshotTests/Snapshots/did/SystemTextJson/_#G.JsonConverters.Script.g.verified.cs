//HintName: G.JsonConverters.Script.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ScriptJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Script>
    {
        /// <inheritdoc />
        public override global::G.Script Read(
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
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("ssml")) __score0++;
            if (__jsonProps.Contains("subtitles")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("audio_url")) __score1++;
            if (__jsonProps.Contains("subtitles")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ScriptVariant1? scriptVariant1 = default;
            global::G.ScriptVariant2? scriptVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        scriptVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ScriptVariant1>(__rawJson, options);
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
                        scriptVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ScriptVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (scriptVariant1 == null && scriptVariant2 == null)
            {
                try
                {
                    scriptVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ScriptVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    scriptVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ScriptVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Script(
                scriptVariant1,

                scriptVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Script value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsScriptVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScriptVariant1, typeof(global::G.ScriptVariant1), options);
            }
            else if (value.IsScriptVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScriptVariant2, typeof(global::G.ScriptVariant2), options);
            }
        }
    }
}