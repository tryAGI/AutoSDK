//HintName: G.JsonConverters.Content3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Content3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Content3>
    {
        /// <inheritdoc />
        public override global::G.Content3 Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.InputContent? inputContent = default;
            global::G.OutputContent? outputContent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        inputContent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputContent>(__rawJson, options);
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

                        outputContent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputContent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputContent == null && outputContent == null)
            {
                try
                {

                    inputContent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    outputContent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Content3(
                inputContent,

                outputContent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Content3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInputContent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputContent, typeof(global::G.InputContent), options);
            }
            else if (value.IsOutputContent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputContent, typeof(global::G.OutputContent), options);
            }
        }
    }
}