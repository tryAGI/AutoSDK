//HintName: G.JsonConverters.OneOf23.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OneOfJsonConverter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> : global::System.Text.Json.Serialization.JsonConverter<global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>
    {
        /// <inheritdoc />
        public override global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> Read(
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
            var __score14 = 0;
            var __score15 = 0;
            var __score16 = 0;
            var __score17 = 0;
            var __score18 = 0;
            var __score19 = 0;
            var __score20 = 0;
            var __score21 = 0;
            var __score22 = 0;
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
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }

            T1? value1 = default;
            T2? value2 = default;
            T3? value3 = default;
            T4? value4 = default;
            T5? value5 = default;
            T6? value6 = default;
            T7? value7 = default;
            T8? value8 = default;
            T9? value9 = default;
            T10? value10 = default;
            T11? value11 = default;
            T12? value12 = default;
            T13? value13 = default;
            T14? value14 = default;
            T15? value15 = default;
            T16? value16 = default;
            T17? value17 = default;
            T18? value18 = default;
            T19? value19 = default;
            T20? value20 = default;
            T21? value21 = default;
            T22? value22 = default;
            T23? value23 = default;
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

                else if (__bestIndex == 7)
                {
                    try
                    {

                        value8 = global::System.Text.Json.JsonSerializer.Deserialize<T8>(__rawJson, options);
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

                        value9 = global::System.Text.Json.JsonSerializer.Deserialize<T9>(__rawJson, options);
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

                        value10 = global::System.Text.Json.JsonSerializer.Deserialize<T10>(__rawJson, options);
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

                        value11 = global::System.Text.Json.JsonSerializer.Deserialize<T11>(__rawJson, options);
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

                        value12 = global::System.Text.Json.JsonSerializer.Deserialize<T12>(__rawJson, options);
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

                        value13 = global::System.Text.Json.JsonSerializer.Deserialize<T13>(__rawJson, options);
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

                        value14 = global::System.Text.Json.JsonSerializer.Deserialize<T14>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 14)
                {
                    try
                    {

                        value15 = global::System.Text.Json.JsonSerializer.Deserialize<T15>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 15)
                {
                    try
                    {

                        value16 = global::System.Text.Json.JsonSerializer.Deserialize<T16>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 16)
                {
                    try
                    {

                        value17 = global::System.Text.Json.JsonSerializer.Deserialize<T17>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 17)
                {
                    try
                    {

                        value18 = global::System.Text.Json.JsonSerializer.Deserialize<T18>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 18)
                {
                    try
                    {

                        value19 = global::System.Text.Json.JsonSerializer.Deserialize<T19>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 19)
                {
                    try
                    {

                        value20 = global::System.Text.Json.JsonSerializer.Deserialize<T20>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 20)
                {
                    try
                    {

                        value21 = global::System.Text.Json.JsonSerializer.Deserialize<T21>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 21)
                {
                    try
                    {

                        value22 = global::System.Text.Json.JsonSerializer.Deserialize<T22>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 22)
                {
                    try
                    {

                        value23 = global::System.Text.Json.JsonSerializer.Deserialize<T23>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null && value5 == null && value6 == null && value7 == null && value8 == null && value9 == null && value10 == null && value11 == null && value12 == null && value13 == null && value14 == null && value15 == null && value16 == null && value17 == null && value18 == null && value19 == null && value20 == null && value21 == null && value22 == null && value23 == null)
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

                try
                {

                    value8 = global::System.Text.Json.JsonSerializer.Deserialize<T8>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value9 = global::System.Text.Json.JsonSerializer.Deserialize<T9>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value10 = global::System.Text.Json.JsonSerializer.Deserialize<T10>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value11 = global::System.Text.Json.JsonSerializer.Deserialize<T11>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value12 = global::System.Text.Json.JsonSerializer.Deserialize<T12>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value13 = global::System.Text.Json.JsonSerializer.Deserialize<T13>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value14 = global::System.Text.Json.JsonSerializer.Deserialize<T14>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value15 = global::System.Text.Json.JsonSerializer.Deserialize<T15>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value16 = global::System.Text.Json.JsonSerializer.Deserialize<T16>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value17 = global::System.Text.Json.JsonSerializer.Deserialize<T17>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value18 = global::System.Text.Json.JsonSerializer.Deserialize<T18>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value19 = global::System.Text.Json.JsonSerializer.Deserialize<T19>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value20 = global::System.Text.Json.JsonSerializer.Deserialize<T20>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value21 = global::System.Text.Json.JsonSerializer.Deserialize<T21>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value22 = global::System.Text.Json.JsonSerializer.Deserialize<T22>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value23 = global::System.Text.Json.JsonSerializer.Deserialize<T23>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(
                value1,

                value2,

                value3,

                value4,

                value5,

                value6,

                value7,

                value8,

                value9,

                value10,

                value11,

                value12,

                value13,

                value14,

                value15,

                value16,

                value17,

                value18,

                value19,

                value20,

                value21,

                value22,

                value23
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> value,
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
            else if (value.IsValue8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeof(T8), options);
            }
            else if (value.IsValue9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeof(T9), options);
            }
            else if (value.IsValue10)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeof(T10), options);
            }
            else if (value.IsValue11)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeof(T11), options);
            }
            else if (value.IsValue12)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeof(T12), options);
            }
            else if (value.IsValue13)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeof(T13), options);
            }
            else if (value.IsValue14)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, typeof(T14), options);
            }
            else if (value.IsValue15)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15, typeof(T15), options);
            }
            else if (value.IsValue16)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16, typeof(T16), options);
            }
            else if (value.IsValue17)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value17, typeof(T17), options);
            }
            else if (value.IsValue18)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value18, typeof(T18), options);
            }
            else if (value.IsValue19)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value19, typeof(T19), options);
            }
            else if (value.IsValue20)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value20, typeof(T20), options);
            }
            else if (value.IsValue21)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value21, typeof(T21), options);
            }
            else if (value.IsValue22)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value22, typeof(T22), options);
            }
            else if (value.IsValue23)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value23, typeof(T23), options);
            }
        }
    }
}