//HintName: G.JsonConverters.RunStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RunStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.RunStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RunStreamEventVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant4? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant4).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant5? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant5).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant6? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant6).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant7? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant7).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant8? value8 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant8).Name}");
                value8 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant9? value9 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant9).Name}");
                value9 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant10? value10 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant10).Name}");
                value10 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.RunStreamEvent(
                value1,
                value2,
                value3,
                value4,
                value5,
                value6,
                value7,
                value8,
                value9,
                value10
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant4).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant5).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant6).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant7).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value8 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant8).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value9 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant9).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value10 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant10).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }
            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }
            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }
            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeInfo);
            }
        }
    }
}