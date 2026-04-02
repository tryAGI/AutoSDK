//HintName: G.JsonConverters.OutputItemFunctionCallStatus.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemFunctionCallStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputItemFunctionCallStatus>
    {
        /// <inheritdoc />
        public override global::G.OutputItemFunctionCallStatus Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.OutputItemFunctionCallStatus0? outputItemFunctionCallStatus0 = default;
            global::G.OutputItemFunctionCallStatus1? outputItemFunctionCallStatus1 = default;
            global::G.OutputItemFunctionCallStatus2? outputItemFunctionCallStatus2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        outputItemFunctionCallStatus0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFunctionCallStatus0>(__rawJson, options);
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

                        outputItemFunctionCallStatus1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFunctionCallStatus1>(__rawJson, options);
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

                        outputItemFunctionCallStatus2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFunctionCallStatus2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputItemFunctionCallStatus0 == null && outputItemFunctionCallStatus1 == null && outputItemFunctionCallStatus2 == null)
            {
                try
                {

                    outputItemFunctionCallStatus0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFunctionCallStatus0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    outputItemFunctionCallStatus1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFunctionCallStatus1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    outputItemFunctionCallStatus2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputItemFunctionCallStatus2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OutputItemFunctionCallStatus(
                outputItemFunctionCallStatus0,

                outputItemFunctionCallStatus1,

                outputItemFunctionCallStatus2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputItemFunctionCallStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOutputItemFunctionCallStatus0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemFunctionCallStatus0, typeof(global::G.OutputItemFunctionCallStatus0), options);
            }
            else if (value.IsOutputItemFunctionCallStatus1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemFunctionCallStatus1, typeof(global::G.OutputItemFunctionCallStatus1), options);
            }
            else if (value.IsOutputItemFunctionCallStatus2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemFunctionCallStatus2, typeof(global::G.OutputItemFunctionCallStatus2), options);
            }
        }
    }
}