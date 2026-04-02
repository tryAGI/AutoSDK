//HintName: G.JsonConverters.JSONValue.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class JSONValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.JSONValue>
    {
        /// <inheritdoc />
        public override global::G.JSONValue Read(
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

            string? jSONValueVariant1 = default;
            double? jSONValueVariant2 = default;
            bool? jSONValueVariant3 = default;
            global::System.Collections.Generic.IList<global::G.JSONValue>? jSONValueVariant4 = default;
            global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>? jSONValueVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        jSONValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        jSONValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
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

                        jSONValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
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

                        jSONValueVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.JSONValue>>(__rawJson, options);
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

                        jSONValueVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (jSONValueVariant1 == null && jSONValueVariant2 == null && jSONValueVariant3 == null && jSONValueVariant4 == null && jSONValueVariant5 == null)
            {
                try
                {

                    jSONValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    jSONValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    jSONValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    jSONValueVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.JSONValue>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    jSONValueVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.JSONValue(
                jSONValueVariant1,

                jSONValueVariant2,

                jSONValueVariant3,

                jSONValueVariant4,

                jSONValueVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.JSONValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsJSONValueVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JSONValueVariant1, typeof(string), options);
            }
            else if (value.IsJSONValueVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JSONValueVariant2, typeof(double), options);
            }
            else if (value.IsJSONValueVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JSONValueVariant3, typeof(bool), options);
            }
            else if (value.IsJSONValueVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JSONValueVariant4, typeof(global::System.Collections.Generic.IList<global::G.JSONValue>), options);
            }
            else if (value.IsJSONValueVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JSONValueVariant5, typeof(global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>), options);
            }
        }
    }
}