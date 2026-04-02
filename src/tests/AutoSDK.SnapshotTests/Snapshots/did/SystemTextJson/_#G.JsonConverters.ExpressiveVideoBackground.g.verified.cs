//HintName: G.JsonConverters.ExpressiveVideoBackground.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ExpressiveVideoBackgroundJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExpressiveVideoBackground>
    {
        /// <inheritdoc />
        public override global::G.ExpressiveVideoBackground Read(
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
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ExpressiveVideoBackgroundVariant1? expressiveVideoBackgroundVariant1 = default;
            global::G.ExpressiveVideoBackgroundVariant2? expressiveVideoBackgroundVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        expressiveVideoBackgroundVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExpressiveVideoBackgroundVariant1>(__rawJson, options);
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
                        expressiveVideoBackgroundVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExpressiveVideoBackgroundVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (expressiveVideoBackgroundVariant1 == null && expressiveVideoBackgroundVariant2 == null)
            {
                try
                {
                    expressiveVideoBackgroundVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExpressiveVideoBackgroundVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    expressiveVideoBackgroundVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExpressiveVideoBackgroundVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ExpressiveVideoBackground(
                expressiveVideoBackgroundVariant1,

                expressiveVideoBackgroundVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExpressiveVideoBackground value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsExpressiveVideoBackgroundVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressiveVideoBackgroundVariant1, typeof(global::G.ExpressiveVideoBackgroundVariant1), options);
            }
            else if (value.IsExpressiveVideoBackgroundVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressiveVideoBackgroundVariant2, typeof(global::G.ExpressiveVideoBackgroundVariant2), options);
            }
        }
    }
}