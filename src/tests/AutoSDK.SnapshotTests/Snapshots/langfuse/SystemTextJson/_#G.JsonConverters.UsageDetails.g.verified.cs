//HintName: G.JsonConverters.UsageDetails.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UsageDetailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UsageDetails>
    {
        /// <inheritdoc />
        public override global::G.UsageDetails Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
            if (__jsonProps.Contains("completion_tokens")) __score1++;
            if (__jsonProps.Contains("completion_tokens_details")) __score1++;
            if (__jsonProps.Contains("prompt_tokens")) __score1++;
            if (__jsonProps.Contains("prompt_tokens_details")) __score1++;
            if (__jsonProps.Contains("total_tokens")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("input_tokens")) __score2++;
            if (__jsonProps.Contains("input_tokens_details")) __score2++;
            if (__jsonProps.Contains("output_tokens")) __score2++;
            if (__jsonProps.Contains("output_tokens_details")) __score2++;
            if (__jsonProps.Contains("total_tokens")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::System.Collections.Generic.Dictionary<string, int>? usageDetailsVariant1 = default;
            global::G.OpenAICompletionUsageSchema? openAICompletionUsageSchema = default;
            global::G.OpenAIResponseUsageSchema? openAIResponseUsageSchema = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, int>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, int>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, int>).Name}");
                        usageDetailsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAICompletionUsageSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAICompletionUsageSchema> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAICompletionUsageSchema).Name}");
                        openAICompletionUsageSchema = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAIResponseUsageSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAIResponseUsageSchema> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAIResponseUsageSchema).Name}");
                        openAIResponseUsageSchema = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (usageDetailsVariant1 == null && openAICompletionUsageSchema == null && openAIResponseUsageSchema == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, int>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, int>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, int>).Name}");
                    usageDetailsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAICompletionUsageSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAICompletionUsageSchema> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAICompletionUsageSchema).Name}");
                    openAICompletionUsageSchema = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAIResponseUsageSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAIResponseUsageSchema> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAIResponseUsageSchema).Name}");
                    openAIResponseUsageSchema = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.UsageDetails(
                usageDetailsVariant1,

                openAICompletionUsageSchema,

                openAIResponseUsageSchema
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UsageDetails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUsageDetailsVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, int>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, int>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, int>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UsageDetailsVariant1!, typeInfo);
            }
            else if (value.IsOpenAICompletionUsageSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAICompletionUsageSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAICompletionUsageSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAICompletionUsageSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAICompletionUsageSchema!, typeInfo);
            }
            else if (value.IsOpenAIResponseUsageSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAIResponseUsageSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAIResponseUsageSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAIResponseUsageSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIResponseUsageSchema!, typeInfo);
            }
        }
    }
}