//HintName: G.JsonConverters.MultiModalQuery.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MultiModalQueryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MultiModalQuery>
    {
        /// <inheritdoc />
        public override global::G.MultiModalQuery Read(
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

            string? multiModalQueryVariant1 = default;
            global::G.MultiModalQueryVariant2? multiModalQueryVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        multiModalQueryVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        multiModalQueryVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MultiModalQueryVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (multiModalQueryVariant1 == null && multiModalQueryVariant2 == null)
            {
                try
                {

                    multiModalQueryVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    multiModalQueryVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MultiModalQueryVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MultiModalQuery(
                multiModalQueryVariant1,

                multiModalQueryVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MultiModalQuery value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMultiModalQueryVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MultiModalQueryVariant1, typeof(string), options);
            }
            else if (value.IsMultiModalQueryVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MultiModalQueryVariant2, typeof(global::G.MultiModalQueryVariant2), options);
            }
        }
    }
}