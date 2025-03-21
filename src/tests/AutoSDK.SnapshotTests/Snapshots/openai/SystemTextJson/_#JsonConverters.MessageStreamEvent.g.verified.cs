//HintName: JsonConverters.MessageStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessageStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessageStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.MessageStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.MessageStreamEventVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageStreamEventVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageStreamEventVariant3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageStreamEventVariant4? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant4).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageStreamEventVariant5? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant5).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.MessageStreamEvent(
                value1,
                value2,
                value3,
                value4,
                value5
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant4).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant5).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessageStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
        }
    }
}