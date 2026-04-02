//HintName: G.JsonConverters.OutputMessagePhase.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputMessagePhaseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputMessagePhase>
    {
        /// <inheritdoc />
        public override global::G.OutputMessagePhase Read(
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

            global::G.OutputMessagePhase0? outputMessagePhase0 = default;
            global::G.OutputMessagePhase1? outputMessagePhase1 = default;
            object? outputMessagePhaseVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        outputMessagePhase0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessagePhase0>(__rawJson, options);
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

                        outputMessagePhase1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessagePhase1>(__rawJson, options);
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

                        outputMessagePhaseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputMessagePhase0 == null && outputMessagePhase1 == null && outputMessagePhaseVariant3 == null)
            {
                try
                {

                    outputMessagePhase0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessagePhase0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    outputMessagePhase1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessagePhase1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    outputMessagePhaseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OutputMessagePhase(
                outputMessagePhase0,

                outputMessagePhase1,

                outputMessagePhaseVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputMessagePhase value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOutputMessagePhase0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessagePhase0, typeof(global::G.OutputMessagePhase0), options);
            }
            else if (value.IsOutputMessagePhase1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessagePhase1, typeof(global::G.OutputMessagePhase1), options);
            }
            else if (value.IsOutputMessagePhaseVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessagePhaseVariant3, typeof(object), options);
            }
        }
    }
}