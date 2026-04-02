//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf8Content.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseMessagesResultContentItemsOneOf8ContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf8Content>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf8Content Read(
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
            if (__jsonProps.Contains("error_code")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("return_code")) __score1++;
            if (__jsonProps.Contains("stderr")) __score1++;
            if (__jsonProps.Contains("stdout")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.BaseMessagesResultContentItemsOneOf8Content0? baseMessagesResultContentItemsOneOf8Content0 = default;
            global::G.BaseMessagesResultContentItemsOneOf8Content1? baseMessagesResultContentItemsOneOf8Content1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        baseMessagesResultContentItemsOneOf8Content0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf8Content0>(__rawJson, options);
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
                        baseMessagesResultContentItemsOneOf8Content1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf8Content1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseMessagesResultContentItemsOneOf8Content0 == null && baseMessagesResultContentItemsOneOf8Content1 == null)
            {
                try
                {
                    baseMessagesResultContentItemsOneOf8Content0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf8Content0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseMessagesResultContentItemsOneOf8Content1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseMessagesResultContentItemsOneOf8Content1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseMessagesResultContentItemsOneOf8Content(
                baseMessagesResultContentItemsOneOf8Content0,

                baseMessagesResultContentItemsOneOf8Content1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf8Content value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBaseMessagesResultContentItemsOneOf8Content0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf8Content0, typeof(global::G.BaseMessagesResultContentItemsOneOf8Content0), options);
            }
            else if (value.IsBaseMessagesResultContentItemsOneOf8Content1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseMessagesResultContentItemsOneOf8Content1, typeof(global::G.BaseMessagesResultContentItemsOneOf8Content1), options);
            }
        }
    }
}