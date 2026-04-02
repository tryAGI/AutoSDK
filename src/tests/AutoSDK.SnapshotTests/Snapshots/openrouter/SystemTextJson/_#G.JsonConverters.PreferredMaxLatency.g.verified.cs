//HintName: G.JsonConverters.PreferredMaxLatency.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PreferredMaxLatencyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PreferredMaxLatency>
    {
        /// <inheritdoc />
        public override global::G.PreferredMaxLatency Read(
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
            if (__jsonProps.Contains("p50")) __score1++;
            if (__jsonProps.Contains("p75")) __score1++;
            if (__jsonProps.Contains("p90")) __score1++;
            if (__jsonProps.Contains("p99")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            double? preferredMaxLatencyVariant1 = default;
            global::G.PercentileLatencyCutoffs? percentileLatencyCutoffs = default;
            object? preferredMaxLatencyVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        preferredMaxLatencyVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
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
                        percentileLatencyCutoffs = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PercentileLatencyCutoffs>(__rawJson, options);
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
                        preferredMaxLatencyVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (preferredMaxLatencyVariant1 == null && percentileLatencyCutoffs == null && preferredMaxLatencyVariant3 == null)
            {
                try
                {
                    preferredMaxLatencyVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    percentileLatencyCutoffs = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PercentileLatencyCutoffs>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    preferredMaxLatencyVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.PreferredMaxLatency(
                preferredMaxLatencyVariant1,

                percentileLatencyCutoffs,

                preferredMaxLatencyVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PreferredMaxLatency value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPreferredMaxLatencyVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreferredMaxLatencyVariant1, typeof(double), options);
            }
            else if (value.IsPercentileLatencyCutoffs)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PercentileLatencyCutoffs, typeof(global::G.PercentileLatencyCutoffs), options);
            }
            else if (value.IsPreferredMaxLatencyVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreferredMaxLatencyVariant3, typeof(object), options);
            }
        }
    }
}