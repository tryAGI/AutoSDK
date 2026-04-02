//HintName: G.JsonConverters.ItemResource.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ItemResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ItemResource>
    {
        /// <inheritdoc />
        public override global::G.ItemResource Read(
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
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("queries")) __score2++;
            if (__jsonProps.Contains("results")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("pending_safety_checks")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            var __score7 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::G.InputMessageResource? inputMessage = default;
            global::G.OutputMessage? message = default;
            global::G.FileSearchToolCall? fileSearchCall = default;
            global::G.ComputerToolCall? computerCall = default;
            global::G.ComputerToolCallOutputResource? computerToolCallOutput = default;
            global::G.WebSearchToolCall? webSearchCall = default;
            global::G.FunctionToolCallResource? functionToolCall = default;
            global::G.FunctionToolCallOutputResource? functionToolCallOutput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        inputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageResource>(__rawJson, options);
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
                        message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
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
                        fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchToolCall>(__rawJson, options);
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
                        computerCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCallOutputResource>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchToolCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCallResource>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        functionToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCallOutputResource>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputMessage == null && message == null && fileSearchCall == null && computerCall == null && computerToolCallOutput == null && webSearchCall == null && functionToolCall == null && functionToolCallOutput == null)
            {
                try
                {
                    inputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCallOutputResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCallResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionToolCallOutputResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ItemResource(
                inputMessage,

                message,

                fileSearchCall,

                computerCall,

                computerToolCallOutput,

                webSearchCall,

                functionToolCall,

                functionToolCallOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ItemResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInputMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage, typeof(global::G.InputMessageResource), options);
            }
            else if (value.IsMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeof(global::G.OutputMessage), options);
            }
            else if (value.IsFileSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall, typeof(global::G.FileSearchToolCall), options);
            }
            else if (value.IsComputerCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall, typeof(global::G.ComputerToolCall), options);
            }
            else if (value.IsComputerToolCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutput, typeof(global::G.ComputerToolCallOutputResource), options);
            }
            else if (value.IsWebSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall, typeof(global::G.WebSearchToolCall), options);
            }
            else if (value.IsFunctionToolCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCall, typeof(global::G.FunctionToolCallResource), options);
            }
            else if (value.IsFunctionToolCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCallOutput, typeof(global::G.FunctionToolCallOutputResource), options);
            }
        }
    }
}