//HintName: G.JsonConverters.ChatRequestImageConfig.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatRequestImageConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatRequestImageConfig>
    {
        /// <inheritdoc />
        public override global::G.ChatRequestImageConfig Read(
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

            string? chatRequestImageConfigVariant1 = default;
            double? chatRequestImageConfigVariant2 = default;
            global::System.Collections.Generic.IList<object>? chatRequestImageConfigVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        chatRequestImageConfigVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        chatRequestImageConfigVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
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

                        chatRequestImageConfigVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<object>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatRequestImageConfigVariant1 == null && chatRequestImageConfigVariant2 == null && chatRequestImageConfigVariant3 == null)
            {
                try
                {

                    chatRequestImageConfigVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatRequestImageConfigVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatRequestImageConfigVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<object>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatRequestImageConfig(
                chatRequestImageConfigVariant1,

                chatRequestImageConfigVariant2,

                chatRequestImageConfigVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatRequestImageConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatRequestImageConfigVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestImageConfigVariant1, typeof(string), options);
            }
            else if (value.IsChatRequestImageConfigVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestImageConfigVariant2, typeof(double), options);
            }
            else if (value.IsChatRequestImageConfigVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestImageConfigVariant3, typeof(global::System.Collections.Generic.IList<object>), options);
            }
        }
    }
}