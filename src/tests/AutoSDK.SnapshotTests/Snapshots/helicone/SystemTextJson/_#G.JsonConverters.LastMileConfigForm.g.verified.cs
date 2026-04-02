//HintName: G.JsonConverters.LastMileConfigForm.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LastMileConfigFormJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LastMileConfigForm>
    {
        /// <inheritdoc />
        public override global::G.LastMileConfigForm Read(
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
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("output")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.BaseLastMileConfigForm? @base = default;
            global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>? lastMileConfigFormVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        @base = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseLastMileConfigForm>(__rawJson, options);
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
                        lastMileConfigFormVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && lastMileConfigFormVariant2 == null)
            {
                try
                {
                    @base = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseLastMileConfigForm>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lastMileConfigFormVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.LastMileConfigForm(
                @base,

                lastMileConfigFormVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LastMileConfigForm value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base, typeof(global::G.BaseLastMileConfigForm), options);
            }
            else if (value.IsLastMileConfigFormVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LastMileConfigFormVariant2, typeof(global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>), options);
            }
        }
    }
}