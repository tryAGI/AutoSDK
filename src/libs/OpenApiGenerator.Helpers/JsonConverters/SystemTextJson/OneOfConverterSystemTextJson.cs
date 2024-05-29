#nullable enable

// ReSharper disable RedundantNameQualifier

// ReSharper disable once CheckNamespace
namespace OpenApiGenerator.JsonConverters
{
    public class OneOfConverterSystemTextJson<T1, T2> : global::System.Text.Json.Serialization.JsonConverter<OneOf<T1, T2>>
    {
        public override OneOf<T1, T2> Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            var readerCopy = reader;
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
        
            var result = new OneOf<T1, T2>
            {
                First = value1,
                Second = value2,
            };
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(T1).Name}, {typeof(T2).Name}>");
            }

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T1>(ref reader);
            }
            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T2>(ref reader);
            }
        
            return result;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            OneOf<T1, T2> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(T1).Name}, {typeof(T2).Name}> object.");
            }

            if (value.IsFirst)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.First, value.First!.GetType(), options);
            }
            else if (value.IsSecond)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Second, value.Second!.GetType(), options);
            }
        }
    }
}