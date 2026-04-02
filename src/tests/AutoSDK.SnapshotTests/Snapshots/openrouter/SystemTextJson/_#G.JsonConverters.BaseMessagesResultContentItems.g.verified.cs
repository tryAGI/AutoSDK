//HintName: G.JsonConverters.BaseMessagesResultContentItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseMessagesResultContentItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItems>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItems Read(
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
            if (__jsonProps.Contains("citations")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("caller")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("input")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("signature")) __score2++;
            if (__jsonProps.Contains("thinking")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("caller")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("input")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("caller")) __score5++;
            if (__jsonProps.Contains("content")) __score5++;
            if (__jsonProps.Contains("tool_use_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("caller")) __score6++;
            if (__jsonProps.Contains("content")) __score6++;
            if (__jsonProps.Contains("tool_use_id")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("content")) __score7++;
            if (__jsonProps.Contains("tool_use_id")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("content")) __score8++;
            if (__jsonProps.Contains("tool_use_id")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("content")) __score9++;
            if (__jsonProps.Contains("tool_use_id")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("content")) __score10++;
            if (__jsonProps.Contains("tool_use_id")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("file_id")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
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
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }

            global::G.BaseMessagesResultContentItems0? baseMessagesResultContentItems0 = default;
            global::G.BaseMessagesResultContentItems1? baseMessagesResultContentItems1 = default;
            global::G.BaseMessagesResultContentItems2? baseMessagesResultContentItems2 = default;
            global::G.BaseMessagesResultContentItems3? baseMessagesResultContentItems3 = default;
            global::G.BaseMessagesResultContentItems4? baseMessagesResultContentItems4 = default;
            global::G.BaseMessagesResultContentItems5? baseMessagesResultContentItems5 = default;
            global::G.BaseMessagesResultContentItems6? baseMessagesResultContentItems6 = default;
            global::G.BaseMessagesResultContentItems7? baseMessagesResultContentItems7 = default;
            global::G.BaseMessagesResultContentItems8? baseMessagesResultContentItems8 = default;
            global::G.BaseMessagesResultContentItems9? baseMessagesResultContentItems9 = default;
            global::G.BaseMessagesResultContentItems10? baseMessagesResultContentItems10 = default;
            global::G.BaseMessagesResultContentItems11? baseMessagesResultContentItems11 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        baseMessagesResultContentItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems0>(__rawJson, options);
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
                        baseMessagesResultContentItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems1>(__rawJson, options);
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
                        baseMessagesResultContentItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems2>(__rawJson, options);
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
                        baseMessagesResultContentItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems3>(__rawJson, options);
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
                        baseMessagesResultContentItems4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems4>(__rawJson, options);
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
                        baseMessagesResultContentItems5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems5>(__rawJson, options);
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
                        baseMessagesResultContentItems6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems6>(__rawJson, options);
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
                        baseMessagesResultContentItems7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems7>(__rawJson, options);
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
                        baseMessagesResultContentItems8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems8>(__rawJson, options);
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
                        baseMessagesResultContentItems9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems9>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        baseMessagesResultContentItems10 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems10>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        baseMessagesResultContentItems11 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems11>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseMessagesResultContentItems0 == null && baseMessagesResultContentItems1 == null && baseMessagesResultContentItems2 == null && baseMessagesResultContentItems3 == null && baseMessagesResultContentItems4 == null && baseMessagesResultContentItems5 == null && baseMessagesResultContentItems6 == null && baseMessagesResultContentItems7 == null && baseMessagesResultContentItems8 == null && baseMessagesResultContentItems9 == null && baseMessagesResultContentItems10 == null && baseMessagesResultContentItems11 == null)
            {
                try
                {
                    baseMessagesResultContentItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems6>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems7>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems8>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems9>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems10 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems10>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItems11 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItems11>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseMessagesResultContentItems(
                baseMessagesResultContentItems0,

                baseMessagesResultContentItems1,

                baseMessagesResultContentItems2,

                baseMessagesResultContentItems3,

                baseMessagesResultContentItems4,

                baseMessagesResultContentItems5,

                baseMessagesResultContentItems6,

                baseMessagesResultContentItems7,

                baseMessagesResultContentItems8,

                baseMessagesResultContentItems9,

                baseMessagesResultContentItems10,

                baseMessagesResultContentItems11
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBaseMessagesResultContentItems0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems0, typeof(global::G.BaseMessagesResultContentItems0), options);
            }
            else if (value.IsBaseMessagesResultContentItems1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems1, typeof(global::G.BaseMessagesResultContentItems1), options);
            }
            else if (value.IsBaseMessagesResultContentItems2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems2, typeof(global::G.BaseMessagesResultContentItems2), options);
            }
            else if (value.IsBaseMessagesResultContentItems3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems3, typeof(global::G.BaseMessagesResultContentItems3), options);
            }
            else if (value.IsBaseMessagesResultContentItems4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems4, typeof(global::G.BaseMessagesResultContentItems4), options);
            }
            else if (value.IsBaseMessagesResultContentItems5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems5, typeof(global::G.BaseMessagesResultContentItems5), options);
            }
            else if (value.IsBaseMessagesResultContentItems6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems6, typeof(global::G.BaseMessagesResultContentItems6), options);
            }
            else if (value.IsBaseMessagesResultContentItems7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems7, typeof(global::G.BaseMessagesResultContentItems7), options);
            }
            else if (value.IsBaseMessagesResultContentItems8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems8, typeof(global::G.BaseMessagesResultContentItems8), options);
            }
            else if (value.IsBaseMessagesResultContentItems9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems9, typeof(global::G.BaseMessagesResultContentItems9), options);
            }
            else if (value.IsBaseMessagesResultContentItems10)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems10, typeof(global::G.BaseMessagesResultContentItems10), options);
            }
            else if (value.IsBaseMessagesResultContentItems11)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItems11, typeof(global::G.BaseMessagesResultContentItems11), options);
            }
        }
    }
}