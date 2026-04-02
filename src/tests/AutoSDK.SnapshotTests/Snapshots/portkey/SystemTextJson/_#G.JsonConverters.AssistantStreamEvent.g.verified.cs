//HintName: G.JsonConverters.AssistantStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AssistantStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AssistantStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.AssistantStreamEvent Read(
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
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("event")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("data")) __score5++;
            if (__jsonProps.Contains("event")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.ThreadStreamEvent? thread = default;
            global::G.RunStreamEvent? run = default;
            global::G.RunStepStreamEvent? runStep = default;
            global::G.MessageStreamEvent? message = default;
            global::G.ErrorEvent? error = default;
            global::G.DoneEvent? done = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        thread = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ThreadStreamEvent>(__rawJson, options);
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
                        run = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEvent>(__rawJson, options);
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
                        runStep = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEvent>(__rawJson, options);
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
                        message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEvent>(__rawJson, options);
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
                        error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ErrorEvent>(__rawJson, options);
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
                        done = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (thread == null && run == null && runStep == null && message == null && error == null && done == null)
            {
                try
                {
                    thread = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ThreadStreamEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    run = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStep = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ErrorEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    done = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AssistantStreamEvent(
                thread,

                run,

                runStep,

                message,

                error,

                done
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AssistantStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsThread)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thread, typeof(global::G.ThreadStreamEvent), options);
            }
            else if (value.IsRun)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Run, typeof(global::G.RunStreamEvent), options);
            }
            else if (value.IsRunStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStep, typeof(global::G.RunStepStreamEvent), options);
            }
            else if (value.IsMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeof(global::G.MessageStreamEvent), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::G.ErrorEvent), options);
            }
            else if (value.IsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done, typeof(global::G.DoneEvent), options);
            }
        }
    }
}