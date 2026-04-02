//HintName: G.JsonConverters.CodeInterpreterServerToolContainer.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CodeInterpreterServerToolContainerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeInterpreterServerToolContainer>
    {
        /// <inheritdoc />
        public override global::G.CodeInterpreterServerToolContainer Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("file_ids")) __score1++;
            if (__jsonProps.Contains("memory_limit")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            string? codeInterpreterServerToolContainerVariant1 = default;
            global::G.CodeInterpreterServerToolContainer1? codeInterpreterServerToolContainer1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        codeInterpreterServerToolContainerVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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
                        codeInterpreterServerToolContainer1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterServerToolContainer1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (codeInterpreterServerToolContainerVariant1 == null && codeInterpreterServerToolContainer1 == null)
            {
                try
                {
                    codeInterpreterServerToolContainerVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    codeInterpreterServerToolContainer1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterServerToolContainer1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CodeInterpreterServerToolContainer(
                codeInterpreterServerToolContainerVariant1,

                codeInterpreterServerToolContainer1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeInterpreterServerToolContainer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCodeInterpreterServerToolContainerVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterServerToolContainerVariant1, typeof(string), options);
            }
            else if (value.IsCodeInterpreterServerToolContainer1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterServerToolContainer1, typeof(global::G.CodeInterpreterServerToolContainer1), options);
            }
        }
    }
}