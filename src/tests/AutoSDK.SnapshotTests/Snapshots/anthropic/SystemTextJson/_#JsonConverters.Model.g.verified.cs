//HintName: JsonConverters.Model.g.cs
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            string? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant4? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant4).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant5? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant5).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant6? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant6).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant7? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant7).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant8? value8 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant8).Name}");
                value8 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant9? value9 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant9).Name}");
                value9 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant10? value10 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant10).Name}");
                value10 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant11? value11 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant11).Name}");
                value11 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant12? value12 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant12).Name}");
                value12 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant13? value13 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant13).Name}");
                value13 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelVariant14? value14 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant14).Name}");
                value14 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Model(
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
                value14
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant4).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant5).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant6).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant7).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value8 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant8).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value9 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant9).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value10 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant10).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value11 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant11).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value12 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant12).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value13 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant13).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value14 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant14).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Model value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }
            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }
            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }
            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeInfo);
            }
            else if (value.IsValue11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeInfo);
            }
            else if (value.IsValue12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeInfo);
            }
            else if (value.IsValue13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeInfo);
            }
            else if (value.IsValue14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, typeInfo);
            }
        }
    }
}