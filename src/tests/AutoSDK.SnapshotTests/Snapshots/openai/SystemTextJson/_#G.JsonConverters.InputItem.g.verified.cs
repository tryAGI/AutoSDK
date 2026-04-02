//HintName: G.JsonConverters.InputItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputItem>
    {
        /// <inheritdoc />
        public override global::G.InputItem Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.EasyInputMessage? message = default;
            global::G.Item? item = default;
            global::G.ItemReferenceParam? itemReference = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessage>(__rawJson, options);
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
                        item = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Item>(__rawJson, options);
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
                        itemReference = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ItemReferenceParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (message == null && item == null && itemReference == null)
            {
                try
                {
                    message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    item = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Item>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    itemReference = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ItemReferenceParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.InputItem(
                message,

                item,

                itemReference
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeof(global::G.EasyInputMessage), options);
            }
            else if (value.IsItem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Item, typeof(global::G.Item), options);
            }
            else if (value.IsItemReference)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ItemReference, typeof(global::G.ItemReferenceParam), options);
            }
        }
    }
}