//HintName: JsonConverters.OneOf20.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class OneOfJsonConverter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : global::System.Text.Json.Serialization.JsonConverter<global::System.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>
    {
        /// <inheritdoc />
        public override global::System.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            var
            readerCopy = reader;
            T1? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<T1>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T2? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<T2>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T3? value3 = default;
            try
            {
                value3 = global::System.Text.Json.JsonSerializer.Deserialize<T3>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T4? value4 = default;
            try
            {
                value4 = global::System.Text.Json.JsonSerializer.Deserialize<T4>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T5? value5 = default;
            try
            {
                value5 = global::System.Text.Json.JsonSerializer.Deserialize<T5>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T6? value6 = default;
            try
            {
                value6 = global::System.Text.Json.JsonSerializer.Deserialize<T6>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T7? value7 = default;
            try
            {
                value7 = global::System.Text.Json.JsonSerializer.Deserialize<T7>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T8? value8 = default;
            try
            {
                value8 = global::System.Text.Json.JsonSerializer.Deserialize<T8>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T9? value9 = default;
            try
            {
                value9 = global::System.Text.Json.JsonSerializer.Deserialize<T9>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T10? value10 = default;
            try
            {
                value10 = global::System.Text.Json.JsonSerializer.Deserialize<T10>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T11? value11 = default;
            try
            {
                value11 = global::System.Text.Json.JsonSerializer.Deserialize<T11>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T12? value12 = default;
            try
            {
                value12 = global::System.Text.Json.JsonSerializer.Deserialize<T12>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T13? value13 = default;
            try
            {
                value13 = global::System.Text.Json.JsonSerializer.Deserialize<T13>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T14? value14 = default;
            try
            {
                value14 = global::System.Text.Json.JsonSerializer.Deserialize<T14>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T15? value15 = default;
            try
            {
                value15 = global::System.Text.Json.JsonSerializer.Deserialize<T15>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T16? value16 = default;
            try
            {
                value16 = global::System.Text.Json.JsonSerializer.Deserialize<T16>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T17? value17 = default;
            try
            {
                value17 = global::System.Text.Json.JsonSerializer.Deserialize<T17>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T18? value18 = default;
            try
            {
                value18 = global::System.Text.Json.JsonSerializer.Deserialize<T18>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T19? value19 = default;
            try
            {
                value19 = global::System.Text.Json.JsonSerializer.Deserialize<T19>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T20? value20 = default;
            try
            {
                value20 = global::System.Text.Json.JsonSerializer.Deserialize<T20>(ref readerCopy);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::System.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(
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

                value20
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(T1).Name}, {typeof(T2).Name}, {typeof(T3).Name}, {typeof(T4).Name}, {typeof(T5).Name}, {typeof(T6).Name}, {typeof(T7).Name}, {typeof(T8).Name}, {typeof(T9).Name}, {typeof(T10).Name}, {typeof(T11).Name}, {typeof(T12).Name}, {typeof(T13).Name}, {typeof(T14).Name}, {typeof(T15).Name}, {typeof(T16).Name}, {typeof(T17).Name}, {typeof(T18).Name}, {typeof(T19).Name}, {typeof(T20).Name}>");
            }

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T1>(ref reader);
            }

            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T2>(ref reader);
            }

            else if (value3 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T3>(ref reader);
            }

            else if (value4 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T4>(ref reader);
            }

            else if (value5 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T5>(ref reader);
            }

            else if (value6 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T6>(ref reader);
            }

            else if (value7 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T7>(ref reader);
            }

            else if (value8 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T8>(ref reader);
            }

            else if (value9 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T9>(ref reader);
            }

            else if (value10 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T10>(ref reader);
            }

            else if (value11 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T11>(ref reader);
            }

            else if (value12 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T12>(ref reader);
            }

            else if (value13 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T13>(ref reader);
            }

            else if (value14 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T14>(ref reader);
            }

            else if (value15 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T15>(ref reader);
            }

            else if (value16 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T16>(ref reader);
            }

            else if (value17 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T17>(ref reader);
            }

            else if (value18 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T18>(ref reader);
            }

            else if (value19 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T19>(ref reader);
            }

            else if (value20 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T20>(ref reader);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::System.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(T1).Name}, {typeof(T2).Name}, {typeof(T3).Name}, {typeof(T4).Name}, {typeof(T5).Name}, {typeof(T6).Name}, {typeof(T7).Name}, {typeof(T8).Name}, {typeof(T9).Name}, {typeof(T10).Name}, {typeof(T11).Name}, {typeof(T12).Name}, {typeof(T13).Name}, {typeof(T14).Name}, {typeof(T15).Name}, {typeof(T16).Name}, {typeof(T17).Name}, {typeof(T18).Name}, {typeof(T19).Name}, {typeof(T20).Name}> object.");
            }

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, value.Value1!.GetType(), options);
            }

            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, value.Value2!.GetType(), options);
            }

            else if (value.IsValue3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, value.Value3!.GetType(), options);
            }

            else if (value.IsValue4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, value.Value4!.GetType(), options);
            }

            else if (value.IsValue5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, value.Value5!.GetType(), options);
            }

            else if (value.IsValue6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, value.Value6!.GetType(), options);
            }

            else if (value.IsValue7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, value.Value7!.GetType(), options);
            }

            else if (value.IsValue8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, value.Value8!.GetType(), options);
            }

            else if (value.IsValue9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, value.Value9!.GetType(), options);
            }

            else if (value.IsValue10)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, value.Value10!.GetType(), options);
            }

            else if (value.IsValue11)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, value.Value11!.GetType(), options);
            }

            else if (value.IsValue12)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, value.Value12!.GetType(), options);
            }

            else if (value.IsValue13)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, value.Value13!.GetType(), options);
            }

            else if (value.IsValue14)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, value.Value14!.GetType(), options);
            }

            else if (value.IsValue15)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15, value.Value15!.GetType(), options);
            }

            else if (value.IsValue16)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16, value.Value16!.GetType(), options);
            }

            else if (value.IsValue17)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value17, value.Value17!.GetType(), options);
            }

            else if (value.IsValue18)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value18, value.Value18!.GetType(), options);
            }

            else if (value.IsValue19)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value19, value.Value19!.GetType(), options);
            }

            else if (value.IsValue20)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value20, value.Value20!.GetType(), options);
            }
        }
    }
}