//HintName: G.JsonConverters.Json.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class JsonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Json>
    {
        /// <inheritdoc />
        public override global::G.Json Read(
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
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            string? jsonVariant1 = default;
            double? jsonVariant2 = default;
            bool? jsonVariant3 = default;
            global::System.Collections.Generic.Dictionary<string, global::G.Json?>? jsonVariant4 = default;
            global::System.Collections.Generic.IList<global::G.Json>? jsonVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        jsonVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        jsonVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
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

                        jsonVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
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

                        jsonVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, global::G.Json?>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        jsonVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Json>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (jsonVariant1 == null && jsonVariant2 == null && jsonVariant3 == null && jsonVariant4 == null && jsonVariant5 == null)
            {
                try
                {

                    jsonVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    jsonVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    jsonVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    jsonVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, global::G.Json?>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    jsonVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Json>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Json(
                jsonVariant1,

                jsonVariant2,

                jsonVariant3,

                jsonVariant4,

                jsonVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Json value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsJsonVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonVariant1, typeof(string), options);
            }
            else if (value.IsJsonVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonVariant2, typeof(double), options);
            }
            else if (value.IsJsonVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonVariant3, typeof(bool), options);
            }
            else if (value.IsJsonVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonVariant4, typeof(global::System.Collections.Generic.Dictionary<string, global::G.Json?>), options);
            }
            else if (value.IsJsonVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonVariant5, typeof(global::System.Collections.Generic.IList<global::G.Json>), options);
            }
        }
    }
}