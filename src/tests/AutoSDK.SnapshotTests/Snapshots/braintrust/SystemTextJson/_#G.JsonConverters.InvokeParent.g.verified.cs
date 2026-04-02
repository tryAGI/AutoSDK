//HintName: G.JsonConverters.InvokeParent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InvokeParentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InvokeParent>
    {
        /// <inheritdoc />
        public override global::G.InvokeParent Read(
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
            if (__jsonProps.Contains("object_id")) __score0++;
            if (__jsonProps.Contains("object_type")) __score0++;
            if (__jsonProps.Contains("propagated_event")) __score0++;
            if (__jsonProps.Contains("row_ids")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.InvokeParentSpanParentStruct? spanParentStruct = default;
            string? invokeParentVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        spanParentStruct = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InvokeParentSpanParentStruct>(__rawJson, options);
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
                        invokeParentVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (spanParentStruct == null && invokeParentVariant2 == null)
            {
                try
                {
                    spanParentStruct = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InvokeParentSpanParentStruct>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    invokeParentVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.InvokeParent(
                spanParentStruct,

                invokeParentVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InvokeParent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSpanParentStruct)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpanParentStruct, typeof(global::G.InvokeParentSpanParentStruct), options);
            }
            else if (value.IsInvokeParentVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvokeParentVariant2, typeof(string), options);
            }
        }
    }
}