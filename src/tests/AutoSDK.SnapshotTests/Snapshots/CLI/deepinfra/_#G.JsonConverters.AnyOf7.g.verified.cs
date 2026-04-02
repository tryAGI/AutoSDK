//HintName: G.JsonConverters.AnyOf7.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnyOfJsonConverter<T1, T2, T3, T4, T5, T6, T7> : global::System.Text.Json.Serialization.JsonConverter<global::G.AnyOf<T1, T2, T3, T4, T5, T6, T7>>
    {
        /// <inheritdoc />
        public override global::G.AnyOf<T1, T2, T3, T4, T5, T6, T7> Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            T1? value1 = default;
            T2? value2 = default;
            T3? value3 = default;
            T4? value4 = default;
            T5? value5 = default;
            T6? value6 = default;
            T7? value7 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        value1 = global::System.Text.Json.JsonSerializer.Deserialize<T1>(__rawJson, options);
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

                        value2 = global::System.Text.Json.JsonSerializer.Deserialize<T2>(__rawJson, options);
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

                        value3 = global::System.Text.Json.JsonSerializer.Deserialize<T3>(__rawJson, options);
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

                        value4 = global::System.Text.Json.JsonSerializer.Deserialize<T4>(__rawJson, options);
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

                        value5 = global::System.Text.Json.JsonSerializer.Deserialize<T5>(__rawJson, options);
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

                        value6 = global::System.Text.Json.JsonSerializer.Deserialize<T6>(__rawJson, options);
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

                        value7 = global::System.Text.Json.JsonSerializer.Deserialize<T7>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null && value5 == null && value6 == null && value7 == null)
            {
                try
                {

                    value1 = global::System.Text.Json.JsonSerializer.Deserialize<T1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value2 = global::System.Text.Json.JsonSerializer.Deserialize<T2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value3 = global::System.Text.Json.JsonSerializer.Deserialize<T3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value4 = global::System.Text.Json.JsonSerializer.Deserialize<T4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value5 = global::System.Text.Json.JsonSerializer.Deserialize<T5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value6 = global::System.Text.Json.JsonSerializer.Deserialize<T6>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value7 = global::System.Text.Json.JsonSerializer.Deserialize<T7>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AnyOf<T1, T2, T3, T4, T5, T6, T7>(
                value1,

                value2,

                value3,

                value4,

                value5,

                value6,

                value7
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnyOf<T1, T2, T3, T4, T5, T6, T7> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(T1), options);
            }
            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(T2), options);
            }
            else if (value.IsValue3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeof(T3), options);
            }
            else if (value.IsValue4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeof(T4), options);
            }
            else if (value.IsValue5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeof(T5), options);
            }
            else if (value.IsValue6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeof(T6), options);
            }
            else if (value.IsValue7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeof(T7), options);
            }
        }
    }
}