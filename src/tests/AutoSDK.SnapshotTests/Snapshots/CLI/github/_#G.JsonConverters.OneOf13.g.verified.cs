//HintName: G.JsonConverters.OneOf13.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OneOfJsonConverter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : global::System.Text.Json.Serialization.JsonConverter<global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
    {
        /// <inheritdoc />
        public override global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            T1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T4? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T4).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T5? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T5).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T6? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T6).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T7? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T7).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T8? value8 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T8).Name}");
                value8 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T9? value9 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T9).Name}");
                value9 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T10? value10 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T10).Name}");
                value10 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T11? value11 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T11).Name}");
                value11 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T12? value12 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T12).Name}");
                value12 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T13? value13 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T13).Name}");
                value13 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
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
                value13
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T4).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T5).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T6).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T7).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value8 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T8).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value9 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T9).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value10 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T10).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value11 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T11).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value12 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T12).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value13 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T13).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }
            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }
            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }
            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeInfo);
            }
            else if (value.IsValue11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeInfo);
            }
            else if (value.IsValue12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeInfo);
            }
            else if (value.IsValue13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeInfo);
            }
        }
    }
}