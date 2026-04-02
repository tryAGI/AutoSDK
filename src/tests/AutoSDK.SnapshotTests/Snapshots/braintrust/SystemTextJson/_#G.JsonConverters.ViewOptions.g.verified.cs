//HintName: G.JsonConverters.ViewOptions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ViewOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ViewOptions>
    {
        /// <inheritdoc />
        public override global::G.ViewOptions Read(
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
            if (__jsonProps.Contains("freezeColumns")) __score0++;
            if (__jsonProps.Contains("options")) __score0++;
            if (__jsonProps.Contains("viewType")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("chartAnnotations")) __score1++;
            if (__jsonProps.Contains("chartHeight")) __score1++;
            if (__jsonProps.Contains("columnOrder")) __score1++;
            if (__jsonProps.Contains("columnSizing")) __score1++;
            if (__jsonProps.Contains("columnVisibility")) __score1++;
            if (__jsonProps.Contains("excludedMeasures")) __score1++;
            if (__jsonProps.Contains("freezeColumns")) __score1++;
            if (__jsonProps.Contains("grouping")) __score1++;
            if (__jsonProps.Contains("layout")) __score1++;
            if (__jsonProps.Contains("queryShape")) __score1++;
            if (__jsonProps.Contains("rowHeight")) __score1++;
            if (__jsonProps.Contains("symbolGrouping")) __score1++;
            if (__jsonProps.Contains("tallGroupRows")) __score1++;
            if (__jsonProps.Contains("timeRangeFilter")) __score1++;
            if (__jsonProps.Contains("xAxis")) __score1++;
            if (__jsonProps.Contains("xAxisAggregation")) __score1++;
            if (__jsonProps.Contains("yMetric")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.ViewOptionsMonitorViewOptions? monitorViewOptions = default;
            global::G.ViewOptionsTableViewOptions? tableViewOptions = default;
            object? viewOptionsVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        monitorViewOptions = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ViewOptionsMonitorViewOptions>(__rawJson, options);
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
                        tableViewOptions = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ViewOptionsTableViewOptions>(__rawJson, options);
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
                        viewOptionsVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (monitorViewOptions == null && tableViewOptions == null && viewOptionsVariant3 == null)
            {
                try
                {
                    monitorViewOptions = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ViewOptionsMonitorViewOptions>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    tableViewOptions = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ViewOptionsTableViewOptions>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    viewOptionsVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ViewOptions(
                monitorViewOptions,

                tableViewOptions,

                viewOptionsVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ViewOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMonitorViewOptions)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MonitorViewOptions, typeof(global::G.ViewOptionsMonitorViewOptions), options);
            }
            else if (value.IsTableViewOptions)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TableViewOptions, typeof(global::G.ViewOptionsTableViewOptions), options);
            }
            else if (value.IsViewOptionsVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ViewOptionsVariant3, typeof(object), options);
            }
        }
    }
}