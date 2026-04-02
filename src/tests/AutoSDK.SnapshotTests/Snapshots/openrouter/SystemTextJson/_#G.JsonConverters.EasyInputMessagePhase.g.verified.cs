//HintName: G.JsonConverters.EasyInputMessagePhase.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EasyInputMessagePhaseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EasyInputMessagePhase>
    {
        /// <inheritdoc />
        public override global::G.EasyInputMessagePhase Read(
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

            global::G.EasyInputMessagePhase0? easyInputMessagePhase0 = default;
            global::G.EasyInputMessagePhase1? easyInputMessagePhase1 = default;
            object? easyInputMessagePhaseVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        easyInputMessagePhase0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessagePhase0>(__rawJson, options);
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

                        easyInputMessagePhase1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessagePhase1>(__rawJson, options);
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

                        easyInputMessagePhaseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (easyInputMessagePhase0 == null && easyInputMessagePhase1 == null && easyInputMessagePhaseVariant3 == null)
            {
                try
                {

                    easyInputMessagePhase0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessagePhase0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    easyInputMessagePhase1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessagePhase1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    easyInputMessagePhaseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EasyInputMessagePhase(
                easyInputMessagePhase0,

                easyInputMessagePhase1,

                easyInputMessagePhaseVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EasyInputMessagePhase value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEasyInputMessagePhase0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessagePhase0, typeof(global::G.EasyInputMessagePhase0), options);
            }
            else if (value.IsEasyInputMessagePhase1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessagePhase1, typeof(global::G.EasyInputMessagePhase1), options);
            }
            else if (value.IsEasyInputMessagePhaseVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessagePhaseVariant3, typeof(object), options);
            }
        }
    }
}