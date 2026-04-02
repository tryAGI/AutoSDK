//HintName: G.JsonConverters.RunStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RunStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.RunStreamEvent Read(
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
            var __score7 = 0;
            if (__jsonProps.Contains("data")) __score7++;
            if (__jsonProps.Contains("event")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("data")) __score8++;
            if (__jsonProps.Contains("event")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("data")) __score9++;
            if (__jsonProps.Contains("event")) __score9++;
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
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::G.RunStreamEventVariant1? runStreamEventVariant1 = default;
            global::G.RunStreamEventVariant2? runStreamEventVariant2 = default;
            global::G.RunStreamEventVariant3? runStreamEventVariant3 = default;
            global::G.RunStreamEventVariant4? runStreamEventVariant4 = default;
            global::G.RunStreamEventVariant5? runStreamEventVariant5 = default;
            global::G.RunStreamEventVariant6? runStreamEventVariant6 = default;
            global::G.RunStreamEventVariant7? runStreamEventVariant7 = default;
            global::G.RunStreamEventVariant8? runStreamEventVariant8 = default;
            global::G.RunStreamEventVariant9? runStreamEventVariant9 = default;
            global::G.RunStreamEventVariant10? runStreamEventVariant10 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        runStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant1>(__rawJson, options);
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
                        runStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant2>(__rawJson, options);
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
                        runStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant3>(__rawJson, options);
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
                        runStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant4>(__rawJson, options);
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
                        runStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant5>(__rawJson, options);
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
                        runStreamEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant6>(__rawJson, options);
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
                        runStreamEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant7>(__rawJson, options);
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
                        runStreamEventVariant8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant8>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        runStreamEventVariant9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant9>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        runStreamEventVariant10 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant10>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {
                    runStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStreamEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant6>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStreamEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant7>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStreamEventVariant8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant8>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStreamEventVariant9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant9>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    runStreamEventVariant10 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant10>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RunStreamEvent(
                runStreamEventVariant1,

                runStreamEventVariant2,

                runStreamEventVariant3,

                runStreamEventVariant4,

                runStreamEventVariant5,

                runStreamEventVariant6,

                runStreamEventVariant7,

                runStreamEventVariant8,

                runStreamEventVariant9,

                runStreamEventVariant10
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsRunStreamEventVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant1, typeof(global::G.RunStreamEventVariant1), options);
            }
            else if (value.IsRunStreamEventVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant2, typeof(global::G.RunStreamEventVariant2), options);
            }
            else if (value.IsRunStreamEventVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant3, typeof(global::G.RunStreamEventVariant3), options);
            }
            else if (value.IsRunStreamEventVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant4, typeof(global::G.RunStreamEventVariant4), options);
            }
            else if (value.IsRunStreamEventVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant5, typeof(global::G.RunStreamEventVariant5), options);
            }
            else if (value.IsRunStreamEventVariant6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant6, typeof(global::G.RunStreamEventVariant6), options);
            }
            else if (value.IsRunStreamEventVariant7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant7, typeof(global::G.RunStreamEventVariant7), options);
            }
            else if (value.IsRunStreamEventVariant8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant8, typeof(global::G.RunStreamEventVariant8), options);
            }
            else if (value.IsRunStreamEventVariant9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant9, typeof(global::G.RunStreamEventVariant9), options);
            }
            else if (value.IsRunStreamEventVariant10)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant10, typeof(global::G.RunStreamEventVariant10), options);
            }
        }
    }
}