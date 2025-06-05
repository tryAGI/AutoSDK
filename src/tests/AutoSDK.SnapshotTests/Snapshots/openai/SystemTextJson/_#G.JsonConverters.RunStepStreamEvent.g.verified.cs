//HintName: G.JsonConverters.RunStepStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RunStepStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStepStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.RunStepStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RunStepStreamEventVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant4? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant4).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant5? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant5).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant6? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant6).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant7? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant7).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.RunStepStreamEvent(
                value1,
                value2,
                value3,
                value4,
                value5,
                value6,
                value7
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant4).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant5).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant6).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant7).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStepStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEventVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEventVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }
        }
    }
}