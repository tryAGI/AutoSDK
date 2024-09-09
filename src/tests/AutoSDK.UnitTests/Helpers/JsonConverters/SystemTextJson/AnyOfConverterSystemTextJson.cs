#nullable enable

// ReSharper disable RedundantNameQualifier

// ReSharper disable once CheckNamespace
namespace AutoSDK.JsonConverters
{
    public class AnyOfConverterSystemTextJson<T1, T2> : global::System.Text.Json.Serialization.JsonConverter<AnyOf<T1, T2>>
    {
        public override AnyOf<T1, T2> Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            //options.TypeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            
            var readerCopy = reader;
            T1? value1 = default;
            try
            {
                if (options.TypeInfoResolver != null)
                {
                    var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
                }
                else
                {
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize<T1>(ref readerCopy, options);
                }
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
        
            readerCopy = reader;
            T2? value2 = default;
            try
            {
                if (options.TypeInfoResolver != null)
                {
                    var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
                }
                else
                {
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize<T2>(ref readerCopy, options);
                }
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
        
            var result = new AnyOf<T1, T2>(value1, value2);
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for AnyOf<{typeof(T1).Name}, {typeof(T2).Name}>");
            }

            if (value1 != null)
            {
                if (options.TypeInfoResolver != null)
                {
                    var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                    _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
                }
                else
                {
                    _ = global::System.Text.Json.JsonSerializer.Deserialize<T1>(ref reader, options);
                }
            }
            else if (value2 != null)
            {
                if (options.TypeInfoResolver != null)
                {
                    var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                    _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
                }
                else
                {
                    _ = global::System.Text.Json.JsonSerializer.Deserialize<T2>(ref reader, options);
                }
            }
        
            return result;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            AnyOf<T1, T2> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid AnyOf<{typeof(T1).Name}, {typeof(T2).Name}> object.");
            }

            if (value.IsValue1)
            {
                if (options.TypeInfoResolver != null)
                {
                    var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1?> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                    global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
                }
                else
                {
                    global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(T1), options);
                }
            }
            else if (value.IsValue2)
            {
                if (options.TypeInfoResolver != null)
                {                
                    var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2?> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                    global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
                }
                else
                {
                    global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(T2), options);
                }
            }
        }
    }
}