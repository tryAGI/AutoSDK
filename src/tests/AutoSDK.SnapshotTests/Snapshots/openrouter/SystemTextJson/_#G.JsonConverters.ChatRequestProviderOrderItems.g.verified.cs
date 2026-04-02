//HintName: G.JsonConverters.ChatRequestProviderOrderItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatRequestProviderOrderItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatRequestProviderOrderItems>
    {
        /// <inheritdoc />
        public override global::G.ChatRequestProviderOrderItems Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ProviderName? providerName = default;
            string? chatRequestProviderOrderItemsVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        providerName = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProviderName>(__rawJson, options);
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

                        chatRequestProviderOrderItemsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (providerName == null && chatRequestProviderOrderItemsVariant2 == null)
            {
                try
                {

                    providerName = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProviderName>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    chatRequestProviderOrderItemsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatRequestProviderOrderItems(
                providerName,

                chatRequestProviderOrderItemsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatRequestProviderOrderItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsProviderName)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ProviderName, typeof(global::G.ProviderName), options);
            }
            else if (value.IsChatRequestProviderOrderItemsVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatRequestProviderOrderItemsVariant2, typeof(string), options);
            }
        }
    }
}