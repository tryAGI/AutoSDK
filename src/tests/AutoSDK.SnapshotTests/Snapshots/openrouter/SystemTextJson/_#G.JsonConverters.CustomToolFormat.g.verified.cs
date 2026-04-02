//HintName: G.JsonConverters.CustomToolFormat.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CustomToolFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CustomToolFormat>
    {
        /// <inheritdoc />
        public override global::G.CustomToolFormat Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("definition")) __score1++;
            if (__jsonProps.Contains("syntax")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.CustomToolFormat0? customToolFormat0 = default;
            global::G.CustomToolFormat1? customToolFormat1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        customToolFormat0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CustomToolFormat0>(__rawJson, options);
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
                        customToolFormat1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CustomToolFormat1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (customToolFormat0 == null && customToolFormat1 == null)
            {
                try
                {
                    customToolFormat0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CustomToolFormat0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    customToolFormat1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CustomToolFormat1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CustomToolFormat(
                customToolFormat0,

                customToolFormat1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CustomToolFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCustomToolFormat0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolFormat0, typeof(global::G.CustomToolFormat0), options);
            }
            else if (value.IsCustomToolFormat1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolFormat1, typeof(global::G.CustomToolFormat1), options);
            }
        }
    }
}