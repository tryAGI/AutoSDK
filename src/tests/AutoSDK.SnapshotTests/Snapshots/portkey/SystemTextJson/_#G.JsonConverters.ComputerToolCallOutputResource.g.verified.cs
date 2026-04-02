//HintName: G.JsonConverters.ComputerToolCallOutputResource.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ComputerToolCallOutputResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ComputerToolCallOutputResource>
    {
        /// <inheritdoc />
        public override global::G.ComputerToolCallOutputResource Read(
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
            if (__jsonProps.Contains("acknowledged_safety_checks")) __score0++;
            if (__jsonProps.Contains("call_id")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("output")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ComputerToolCallOutput? computerToolCallOutput = default;
            global::G.ComputerToolCallOutputResourceVariant2? computerToolCallOutputResourceVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCallOutput>(__rawJson, options);
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
                        computerToolCallOutputResourceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCallOutputResourceVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (computerToolCallOutput == null && computerToolCallOutputResourceVariant2 == null)
            {
                try
                {
                    computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCallOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerToolCallOutputResourceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerToolCallOutputResourceVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ComputerToolCallOutputResource(
                computerToolCallOutput,

                computerToolCallOutputResourceVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ComputerToolCallOutputResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsComputerToolCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutput, typeof(global::G.ComputerToolCallOutput), options);
            }
            else if (value.IsComputerToolCallOutputResourceVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutputResourceVariant2, typeof(global::G.ComputerToolCallOutputResourceVariant2), options);
            }
        }
    }
}