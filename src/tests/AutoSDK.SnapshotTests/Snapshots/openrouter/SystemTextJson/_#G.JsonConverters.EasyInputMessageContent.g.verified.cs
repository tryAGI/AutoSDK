//HintName: G.JsonConverters.EasyInputMessageContent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EasyInputMessageContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EasyInputMessageContent>
    {
        /// <inheritdoc />
        public override global::G.EasyInputMessageContent Read(
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

            global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>? easyInputMessageContent0 = default;
            string? easyInputMessageContentVariant2 = default;
            object? easyInputMessageContentVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        easyInputMessageContent0 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>>(__rawJson, options);
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

                        easyInputMessageContentVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        easyInputMessageContentVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (easyInputMessageContent0 == null && easyInputMessageContentVariant2 == null && easyInputMessageContentVariant3 == null)
            {
                try
                {

                    easyInputMessageContent0 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    easyInputMessageContentVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    easyInputMessageContentVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EasyInputMessageContent(
                easyInputMessageContent0,

                easyInputMessageContentVariant2,

                easyInputMessageContentVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EasyInputMessageContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEasyInputMessageContent0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessageContent0, typeof(global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>), options);
            }
            else if (value.IsEasyInputMessageContentVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessageContentVariant2, typeof(string), options);
            }
            else if (value.IsEasyInputMessageContentVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessageContentVariant3, typeof(object), options);
            }
        }
    }
}