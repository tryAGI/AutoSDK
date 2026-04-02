//HintName: G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2Source.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesMessageParamContentOneOf1ItemsOneOf2SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source>
    {
        /// <inheritdoc />
        public override global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source Read(
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
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("url")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source0? messagesMessageParamContentOneOf1ItemsOneOf2Source0 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source1? messagesMessageParamContentOneOf1ItemsOneOf2Source1 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source2? messagesMessageParamContentOneOf1ItemsOneOf2Source2 = default;
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source3? messagesMessageParamContentOneOf1ItemsOneOf2Source3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        messagesMessageParamContentOneOf1ItemsOneOf2Source0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source0>(__rawJson, options);
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
                        messagesMessageParamContentOneOf1ItemsOneOf2Source1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source1>(__rawJson, options);
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
                        messagesMessageParamContentOneOf1ItemsOneOf2Source2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source2>(__rawJson, options);
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
                        messagesMessageParamContentOneOf1ItemsOneOf2Source3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesMessageParamContentOneOf1ItemsOneOf2Source0 == null && messagesMessageParamContentOneOf1ItemsOneOf2Source1 == null && messagesMessageParamContentOneOf1ItemsOneOf2Source2 == null && messagesMessageParamContentOneOf1ItemsOneOf2Source3 == null)
            {
                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf2Source0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf2Source1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf2Source2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    messagesMessageParamContentOneOf1ItemsOneOf2Source3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source(
                messagesMessageParamContentOneOf1ItemsOneOf2Source0,

                messagesMessageParamContentOneOf1ItemsOneOf2Source1,

                messagesMessageParamContentOneOf1ItemsOneOf2Source2,

                messagesMessageParamContentOneOf1ItemsOneOf2Source3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf2Source0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf2Source0, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source0), options);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf2Source1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf2Source1, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source1), options);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf2Source2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf2Source2, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source2), options);
            }
            else if (value.IsMessagesMessageParamContentOneOf1ItemsOneOf2Source3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesMessageParamContentOneOf1ItemsOneOf2Source3, typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2Source3), options);
            }
        }
    }
}