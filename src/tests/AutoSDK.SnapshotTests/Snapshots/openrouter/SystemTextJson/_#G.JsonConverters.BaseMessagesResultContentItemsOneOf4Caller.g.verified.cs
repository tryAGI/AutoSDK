//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf4Caller.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseMessagesResultContentItemsOneOf4CallerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf4Caller>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf4Caller Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("tool_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("tool_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.BaseMessagesResultContentItemsOneOf4Caller0? baseMessagesResultContentItemsOneOf4Caller0 = default;
            global::G.BaseMessagesResultContentItemsOneOf4Caller1? baseMessagesResultContentItemsOneOf4Caller1 = default;
            global::G.BaseMessagesResultContentItemsOneOf4Caller2? baseMessagesResultContentItemsOneOf4Caller2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        baseMessagesResultContentItemsOneOf4Caller0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf4Caller0>(__rawJson, options);
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
                        baseMessagesResultContentItemsOneOf4Caller1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf4Caller1>(__rawJson, options);
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
                        baseMessagesResultContentItemsOneOf4Caller2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf4Caller2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseMessagesResultContentItemsOneOf4Caller0 == null && baseMessagesResultContentItemsOneOf4Caller1 == null && baseMessagesResultContentItemsOneOf4Caller2 == null)
            {
                try
                {
                    baseMessagesResultContentItemsOneOf4Caller0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf4Caller0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItemsOneOf4Caller1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf4Caller1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItemsOneOf4Caller2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf4Caller2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseMessagesResultContentItemsOneOf4Caller(
                baseMessagesResultContentItemsOneOf4Caller0,

                baseMessagesResultContentItemsOneOf4Caller1,

                baseMessagesResultContentItemsOneOf4Caller2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf4Caller value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBaseMessagesResultContentItemsOneOf4Caller0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf4Caller0, typeof(global::G.BaseMessagesResultContentItemsOneOf4Caller0), options);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf4Caller1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf4Caller1, typeof(global::G.BaseMessagesResultContentItemsOneOf4Caller1), options);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf4Caller2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf4Caller2, typeof(global::G.BaseMessagesResultContentItemsOneOf4Caller2), options);
            }
        }
    }
}