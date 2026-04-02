//HintName: G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items>
    {
        /// <inheritdoc />
        public override global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items Read(
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
            if (__jsonProps.Contains("cache_control")) __score0++;
            if (__jsonProps.Contains("citations")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("cache_control")) __score1++;
            if (__jsonProps.Contains("source")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0>(__rawJson, options);
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
                        messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0 == null && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1 == null)
            {
                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items(
                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0,

                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0), options);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items1), options);
            }
        }
    }
}