//HintName: G.JsonConverters.PreferredMinThroughput.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PreferredMinThroughputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PreferredMinThroughput>
    {
        /// <inheritdoc />
        public override global::G.PreferredMinThroughput Read(
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

            double? preferredMinThroughputVariant1 = default;
            global::G.PercentileThroughputCutoffs? percentileThroughputCutoffs = default;
            object? preferredMinThroughputVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        preferredMinThroughputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
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
                        percentileThroughputCutoffs = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PercentileThroughputCutoffs>(__rawJson, options);
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
                        preferredMinThroughputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (preferredMinThroughputVariant1 == null && percentileThroughputCutoffs == null && preferredMinThroughputVariant3 == null)
            {
                try
                {
                    preferredMinThroughputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    percentileThroughputCutoffs = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PercentileThroughputCutoffs>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    preferredMinThroughputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.PreferredMinThroughput(
                preferredMinThroughputVariant1,

                percentileThroughputCutoffs,

                preferredMinThroughputVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PreferredMinThroughput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPreferredMinThroughputVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreferredMinThroughputVariant1, typeof(double), options);
            }
            else if (value.IsPercentileThroughputCutoffs)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PercentileThroughputCutoffs, typeof(global::G.PercentileThroughputCutoffs), options);
            }
            else if (value.IsPreferredMinThroughputVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreferredMinThroughputVariant3, typeof(object), options);
            }
        }
    }
}