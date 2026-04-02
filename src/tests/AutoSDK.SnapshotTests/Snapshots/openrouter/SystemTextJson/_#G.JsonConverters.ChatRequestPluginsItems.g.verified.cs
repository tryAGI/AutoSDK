//HintName: G.JsonConverters.ChatRequestPluginsItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatRequestPluginsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatRequestPluginsItems>
    {
        /// <inheritdoc />
        public override global::G.ChatRequestPluginsItems Read(
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
            if (__jsonProps.Contains("allowed_models")) __score0++;
            if (__jsonProps.Contains("enabled")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("enabled")) __score2++;
            if (__jsonProps.Contains("engine")) __score2++;
            if (__jsonProps.Contains("exclude_domains")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("include_domains")) __score2++;
            if (__jsonProps.Contains("max_results")) __score2++;
            if (__jsonProps.Contains("search_prompt")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("enabled")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("pdf")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("enabled")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("enabled")) __score5++;
            if (__jsonProps.Contains("engine")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.ChatRequestPluginsItems0? chatRequestPluginsItems0 = default;
            global::G.ChatRequestPluginsItems1? chatRequestPluginsItems1 = default;
            global::G.ChatRequestPluginsItems2? chatRequestPluginsItems2 = default;
            global::G.ChatRequestPluginsItems3? chatRequestPluginsItems3 = default;
            global::G.ChatRequestPluginsItems4? chatRequestPluginsItems4 = default;
            global::G.ChatRequestPluginsItems5? chatRequestPluginsItems5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        chatRequestPluginsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems0>(__rawJson, options);
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
                        chatRequestPluginsItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems1>(__rawJson, options);
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
                        chatRequestPluginsItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems2>(__rawJson, options);
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
                        chatRequestPluginsItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems3>(__rawJson, options);
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
                        chatRequestPluginsItems4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems4>(__rawJson, options);
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
                        chatRequestPluginsItems5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems5>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatRequestPluginsItems0 == null && chatRequestPluginsItems1 == null && chatRequestPluginsItems2 == null && chatRequestPluginsItems3 == null && chatRequestPluginsItems4 == null && chatRequestPluginsItems5 == null)
            {
                try
                {
                    chatRequestPluginsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatRequestPluginsItems1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatRequestPluginsItems2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatRequestPluginsItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatRequestPluginsItems4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatRequestPluginsItems5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequestPluginsItems5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatRequestPluginsItems(
                chatRequestPluginsItems0,

                chatRequestPluginsItems1,

                chatRequestPluginsItems2,

                chatRequestPluginsItems3,

                chatRequestPluginsItems4,

                chatRequestPluginsItems5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatRequestPluginsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatRequestPluginsItems0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestPluginsItems0, typeof(global::G.ChatRequestPluginsItems0), options);
            }
            else if (value.IsChatRequestPluginsItems1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestPluginsItems1, typeof(global::G.ChatRequestPluginsItems1), options);
            }
            else if (value.IsChatRequestPluginsItems2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestPluginsItems2, typeof(global::G.ChatRequestPluginsItems2), options);
            }
            else if (value.IsChatRequestPluginsItems3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestPluginsItems3, typeof(global::G.ChatRequestPluginsItems3), options);
            }
            else if (value.IsChatRequestPluginsItems4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestPluginsItems4, typeof(global::G.ChatRequestPluginsItems4), options);
            }
            else if (value.IsChatRequestPluginsItems5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestPluginsItems5, typeof(global::G.ChatRequestPluginsItems5), options);
            }
        }
    }
}