//HintName: G.JsonConverters.EventsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EventsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EventsItem>
    {
        /// <inheritdoc />
        public override global::G.EventsItem Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("timestamp")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("timestamp")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("timestamp")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("timestamp")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("timestamp")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.MetadataSendTelemetryRequestEventVariant1? sessionStart = default;
            global::G.MetadataSendTelemetryRequestEventVariant2? sessionEnd = default;
            global::G.MetadataSendTelemetryRequestEventVariant3? toolUsage = default;
            global::G.MetadataSendTelemetryRequestEventVariant4? error = default;
            global::G.MetadataSendTelemetryRequestEventVariant5? userInput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        sessionStart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant1>(__rawJson, options);
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
                        sessionEnd = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant2>(__rawJson, options);
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
                        toolUsage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant3>(__rawJson, options);
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
                        error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant4>(__rawJson, options);
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
                        userInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant5>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (sessionStart == null && sessionEnd == null && toolUsage == null && error == null && userInput == null)
            {
                try
                {
                    sessionStart = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sessionEnd = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolUsage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    userInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetadataSendTelemetryRequestEventVariant5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EventsItem(
                sessionStart,

                sessionEnd,

                toolUsage,

                error,

                userInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EventsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSessionStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStart, typeof(global::G.MetadataSendTelemetryRequestEventVariant1), options);
            }
            else if (value.IsSessionEnd)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionEnd, typeof(global::G.MetadataSendTelemetryRequestEventVariant2), options);
            }
            else if (value.IsToolUsage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUsage, typeof(global::G.MetadataSendTelemetryRequestEventVariant3), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::G.MetadataSendTelemetryRequestEventVariant4), options);
            }
            else if (value.IsUserInput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserInput, typeof(global::G.MetadataSendTelemetryRequestEventVariant5), options);
            }
        }
    }
}