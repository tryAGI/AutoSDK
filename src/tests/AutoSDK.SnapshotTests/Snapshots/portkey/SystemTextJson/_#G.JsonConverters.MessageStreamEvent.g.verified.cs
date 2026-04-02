//HintName: G.JsonConverters.MessageStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessageStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessageStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.MessageStreamEvent Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.MessageStreamEventVariant1? messageStreamEventVariant1 = default;
            global::G.MessageStreamEventVariant2? messageStreamEventVariant2 = default;
            global::G.MessageStreamEventVariant3? messageStreamEventVariant3 = default;
            global::G.MessageStreamEventVariant4? messageStreamEventVariant4 = default;
            global::G.MessageStreamEventVariant5? messageStreamEventVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        messageStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant1>(__rawJson, options);
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
                        messageStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant2>(__rawJson, options);
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
                        messageStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant3>(__rawJson, options);
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
                        messageStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant4>(__rawJson, options);
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
                        messageStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant5>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messageStreamEventVariant1 == null && messageStreamEventVariant2 == null && messageStreamEventVariant3 == null && messageStreamEventVariant4 == null && messageStreamEventVariant5 == null)
            {
                try
                {
                    messageStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messageStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messageStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messageStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messageStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEventVariant5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessageStreamEvent(
                messageStreamEventVariant1,

                messageStreamEventVariant2,

                messageStreamEventVariant3,

                messageStreamEventVariant4,

                messageStreamEventVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessageStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessageStreamEventVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStreamEventVariant1, typeof(global::G.MessageStreamEventVariant1), options);
            }
            else if (value.IsMessageStreamEventVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStreamEventVariant2, typeof(global::G.MessageStreamEventVariant2), options);
            }
            else if (value.IsMessageStreamEventVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStreamEventVariant3, typeof(global::G.MessageStreamEventVariant3), options);
            }
            else if (value.IsMessageStreamEventVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStreamEventVariant4, typeof(global::G.MessageStreamEventVariant4), options);
            }
            else if (value.IsMessageStreamEventVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStreamEventVariant5, typeof(global::G.MessageStreamEventVariant5), options);
            }
        }
    }
}