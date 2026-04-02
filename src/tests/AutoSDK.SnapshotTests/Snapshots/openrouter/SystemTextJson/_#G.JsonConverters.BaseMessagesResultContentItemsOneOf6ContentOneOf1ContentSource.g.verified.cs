//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource Read(
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
            if (__jsonProps.Contains("media_type")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("media_type")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = default;
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0>(__rawJson, options);
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
                        baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 == null && baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 == null)
            {
                try
                {
                    baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(
                baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0,

                baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0, typeof(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0), options);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1, typeof(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource1), options);
            }
        }
    }
}