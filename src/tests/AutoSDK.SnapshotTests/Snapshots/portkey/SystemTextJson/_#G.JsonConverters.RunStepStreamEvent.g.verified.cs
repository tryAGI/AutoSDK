//HintName: G.JsonConverters.RunStepStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RunStepStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStepStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.RunStepStreamEvent Read(
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
            if (__jsonProps.Contains("event")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("event")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("event")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("event")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("event")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("data")) __score5++;
            if (__jsonProps.Contains("event")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("data")) __score6++;
            if (__jsonProps.Contains("event")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::G.RunStepStreamEventVariant1? runStepStreamEventVariant1 = default;
            global::G.RunStepStreamEventVariant2? runStepStreamEventVariant2 = default;
            global::G.RunStepStreamEventVariant3? runStepStreamEventVariant3 = default;
            global::G.RunStepStreamEventVariant4? runStepStreamEventVariant4 = default;
            global::G.RunStepStreamEventVariant5? runStepStreamEventVariant5 = default;
            global::G.RunStepStreamEventVariant6? runStepStreamEventVariant6 = default;
            global::G.RunStepStreamEventVariant7? runStepStreamEventVariant7 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        runStepStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant1>(__rawJson, options);
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
                        runStepStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant2>(__rawJson, options);
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
                        runStepStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant3>(__rawJson, options);
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
                        runStepStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant4>(__rawJson, options);
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
                        runStepStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant5>(__rawJson, options);
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
                        runStepStreamEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant6>(__rawJson, options);
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
                        runStepStreamEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant7>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (runStepStreamEventVariant1 == null && runStepStreamEventVariant2 == null && runStepStreamEventVariant3 == null && runStepStreamEventVariant4 == null && runStepStreamEventVariant5 == null && runStepStreamEventVariant6 == null && runStepStreamEventVariant7 == null)
            {
                try
                {
                    runStepStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStepStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStepStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStepStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStepStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStepStreamEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant6>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStepStreamEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant7>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RunStepStreamEvent(
                runStepStreamEventVariant1,

                runStepStreamEventVariant2,

                runStepStreamEventVariant3,

                runStepStreamEventVariant4,

                runStepStreamEventVariant5,

                runStepStreamEventVariant6,

                runStepStreamEventVariant7
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStepStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsRunStepStreamEventVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepStreamEventVariant1, typeof(global::G.RunStepStreamEventVariant1), options);
            }
            else if (value.IsRunStepStreamEventVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepStreamEventVariant2, typeof(global::G.RunStepStreamEventVariant2), options);
            }
            else if (value.IsRunStepStreamEventVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepStreamEventVariant3, typeof(global::G.RunStepStreamEventVariant3), options);
            }
            else if (value.IsRunStepStreamEventVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepStreamEventVariant4, typeof(global::G.RunStepStreamEventVariant4), options);
            }
            else if (value.IsRunStepStreamEventVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepStreamEventVariant5, typeof(global::G.RunStepStreamEventVariant5), options);
            }
            else if (value.IsRunStepStreamEventVariant6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepStreamEventVariant6, typeof(global::G.RunStepStreamEventVariant6), options);
            }
            else if (value.IsRunStepStreamEventVariant7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepStreamEventVariant7, typeof(global::G.RunStepStreamEventVariant7), options);
            }
        }
    }
}