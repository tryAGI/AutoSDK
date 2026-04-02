//HintName: G.JsonConverters.ChatCompletionMessageParam.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionMessageParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionMessageParam>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionMessageParam Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("function_call")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("reasoning")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("tool_calls")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("content")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            if (__jsonProps.Contains("tool_call_id")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("content")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("role")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("content")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("role")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("content")) __score6++;
            if (__jsonProps.Contains("role")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::G.ChatCompletionMessageParamSystem? system = default;
            global::G.ChatCompletionMessageParamUser? user = default;
            global::G.ChatCompletionMessageParamAssistant? assistant = default;
            global::G.ChatCompletionMessageParamTool? tool = default;
            global::G.ChatCompletionMessageParamFunction? function = default;
            global::G.ChatCompletionMessageParamDeveloper? developer = default;
            global::G.ChatCompletionMessageParamFallback? fallback = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        system = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamSystem>(__rawJson, options);
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
                        user = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamUser>(__rawJson, options);
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
                        assistant = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamAssistant>(__rawJson, options);
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
                        tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamTool>(__rawJson, options);
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
                        function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamFunction>(__rawJson, options);
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
                        developer = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamDeveloper>(__rawJson, options);
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
                        fallback = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamFallback>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (system == null && user == null && assistant == null && tool == null && function == null && developer == null && fallback == null)
            {
                try
                {
                    system = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamSystem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    user = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamUser>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    assistant = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamAssistant>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamFunction>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    developer = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamDeveloper>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fallback = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionMessageParamFallback>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatCompletionMessageParam(
                system,

                user,

                assistant,

                tool,

                function,

                developer,

                fallback
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionMessageParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::G.ChatCompletionMessageParamSystem), options);
            }
            else if (value.IsUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeof(global::G.ChatCompletionMessageParamUser), options);
            }
            else if (value.IsAssistant)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeof(global::G.ChatCompletionMessageParamAssistant), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.ChatCompletionMessageParamTool), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.ChatCompletionMessageParamFunction), options);
            }
            else if (value.IsDeveloper)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Developer, typeof(global::G.ChatCompletionMessageParamDeveloper), options);
            }
            else if (value.IsFallback)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Fallback, typeof(global::G.ChatCompletionMessageParamFallback), options);
            }
        }
    }
}