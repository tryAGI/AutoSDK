//HintName: G.JsonConverters.Model.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Model>
    {
        /// <inheritdoc />
        public override global::G.Model Read(
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
            var __score5 = 0;
            var __score6 = 0;
            var __score7 = 0;
            var __score8 = 0;
            var __score9 = 0;
            var __score10 = 0;
            var __score11 = 0;
            var __score12 = 0;
            var __score13 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }

            string? modelVariant1 = default;
            string? modelVariant2 = default;
            string? modelVariant3 = default;
            string? modelVariant4 = default;
            string? modelVariant5 = default;
            string? modelVariant6 = default;
            string? modelVariant7 = default;
            string? modelVariant8 = default;
            string? modelVariant9 = default;
            string? modelVariant10 = default;
            string? modelVariant11 = default;
            string? modelVariant12 = default;
            string? modelVariant13 = default;
            string? modelVariant14 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        modelVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        modelVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        modelVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        modelVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        modelVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 5)
                {
                    try
                    {

                        modelVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 6)
                {
                    try
                    {

                        modelVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 7)
                {
                    try
                    {

                        modelVariant8 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 8)
                {
                    try
                    {

                        modelVariant9 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 9)
                {
                    try
                    {

                        modelVariant10 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 10)
                {
                    try
                    {

                        modelVariant11 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 11)
                {
                    try
                    {

                        modelVariant12 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 12)
                {
                    try
                    {

                        modelVariant13 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 13)
                {
                    try
                    {

                        modelVariant14 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (modelVariant1 == null && modelVariant2 == null && modelVariant3 == null && modelVariant4 == null && modelVariant5 == null && modelVariant6 == null && modelVariant7 == null && modelVariant8 == null && modelVariant9 == null && modelVariant10 == null && modelVariant11 == null && modelVariant12 == null && modelVariant13 == null && modelVariant14 == null)
            {
                try
                {

                    modelVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant8 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant9 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant10 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant11 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant12 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant13 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelVariant14 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Model(
                modelVariant1,

                modelVariant2,

                modelVariant3,

                modelVariant4,

                modelVariant5,

                modelVariant6,

                modelVariant7,

                modelVariant8,

                modelVariant9,

                modelVariant10,

                modelVariant11,

                modelVariant12,

                modelVariant13,

                modelVariant14
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Model value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsModelVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant1, typeof(string), options);
            }
            else if (value.IsModelVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant2, typeof(string), options);
            }
            else if (value.IsModelVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant3, typeof(string), options);
            }
            else if (value.IsModelVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant4, typeof(string), options);
            }
            else if (value.IsModelVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant5, typeof(string), options);
            }
            else if (value.IsModelVariant6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant6, typeof(string), options);
            }
            else if (value.IsModelVariant7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant7, typeof(string), options);
            }
            else if (value.IsModelVariant8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant8, typeof(string), options);
            }
            else if (value.IsModelVariant9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant9, typeof(string), options);
            }
            else if (value.IsModelVariant10)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant10, typeof(string), options);
            }
            else if (value.IsModelVariant11)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant11, typeof(string), options);
            }
            else if (value.IsModelVariant12)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant12, typeof(string), options);
            }
            else if (value.IsModelVariant13)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant13, typeof(string), options);
            }
            else if (value.IsModelVariant14)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelVariant14, typeof(string), options);
            }
        }
    }
}