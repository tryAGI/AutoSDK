//HintName: G.JsonConverters.DataEntry.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DataEntryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DataEntry>
    {
        /// <inheritdoc />
        public override global::G.DataEntry Read(
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
            if (__jsonProps.Contains("_type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("_type")) __score1++;
            if (__jsonProps.Contains("inputKey")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("_type")) __score2++;
            if (__jsonProps.Contains("content")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("_type")) __score3++;
            if (__jsonProps.Contains("content")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.DataEntryVariant1? dataEntryVariant1 = default;
            global::G.DataEntryVariant2? dataEntryVariant2 = default;
            global::G.DataEntryVariant3? dataEntryVariant3 = default;
            global::G.DataEntryVariant4? dataEntryVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        dataEntryVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataEntryVariant1>(__rawJson, options);
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
                        dataEntryVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataEntryVariant2>(__rawJson, options);
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
                        dataEntryVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataEntryVariant3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        dataEntryVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataEntryVariant4>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (dataEntryVariant1 == null && dataEntryVariant2 == null && dataEntryVariant3 == null && dataEntryVariant4 == null)
            {
                try
                {
                    dataEntryVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataEntryVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    dataEntryVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataEntryVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    dataEntryVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataEntryVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    dataEntryVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataEntryVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.DataEntry(
                dataEntryVariant1,

                dataEntryVariant2,

                dataEntryVariant3,

                dataEntryVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DataEntry value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsDataEntryVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DataEntryVariant1, typeof(global::G.DataEntryVariant1), options);
            }
            else if (value.IsDataEntryVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DataEntryVariant2, typeof(global::G.DataEntryVariant2), options);
            }
            else if (value.IsDataEntryVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DataEntryVariant3, typeof(global::G.DataEntryVariant3), options);
            }
            else if (value.IsDataEntryVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DataEntryVariant4, typeof(global::G.DataEntryVariant4), options);
            }
        }
    }
}