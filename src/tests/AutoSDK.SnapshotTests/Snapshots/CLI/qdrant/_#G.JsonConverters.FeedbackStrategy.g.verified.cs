//HintName: G.JsonConverters.FeedbackStrategy.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FeedbackStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FeedbackStrategy>
    {
        /// <inheritdoc />
        public override global::G.FeedbackStrategy Read(
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
            if (__jsonProps.Contains("naive")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::G.NaiveFeedbackStrategy? naive = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NaiveFeedbackStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NaiveFeedbackStrategy> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NaiveFeedbackStrategy).Name}");
                        naive = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (naive == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NaiveFeedbackStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NaiveFeedbackStrategy> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NaiveFeedbackStrategy).Name}");
                    naive = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FeedbackStrategy(
                naive
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FeedbackStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNaive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NaiveFeedbackStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NaiveFeedbackStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NaiveFeedbackStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Naive!, typeInfo);
            }
        }
    }
}