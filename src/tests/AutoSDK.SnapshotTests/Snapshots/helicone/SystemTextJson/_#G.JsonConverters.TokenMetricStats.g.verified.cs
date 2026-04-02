//HintName: G.JsonConverters.TokenMetricStats.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TokenMetricStatsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TokenMetricStats>
    {
        /// <inheritdoc />
        public override global::G.TokenMetricStats Read(
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
            if (__jsonProps.Contains("average")) __score0++;
            if (__jsonProps.Contains("max")) __score0++;
            if (__jsonProps.Contains("median")) __score0++;
            if (__jsonProps.Contains("min")) __score0++;
            if (__jsonProps.Contains("p90")) __score0++;
            if (__jsonProps.Contains("p95")) __score0++;
            if (__jsonProps.Contains("p99")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("medianPer1000Tokens")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.MetricStats? metricStats = default;
            global::G.TokenMetricStatsVariant2? tokenMetricStatsVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        metricStats = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetricStats>(__rawJson, options);
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
                        tokenMetricStatsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TokenMetricStatsVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (metricStats == null && tokenMetricStatsVariant2 == null)
            {
                try
                {
                    metricStats = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MetricStats>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    tokenMetricStatsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TokenMetricStatsVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TokenMetricStats(
                metricStats,

                tokenMetricStatsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TokenMetricStats value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMetricStats)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MetricStats, typeof(global::G.MetricStats), options);
            }
            else if (value.IsTokenMetricStatsVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TokenMetricStatsVariant2, typeof(global::G.TokenMetricStatsVariant2), options);
            }
        }
    }
}