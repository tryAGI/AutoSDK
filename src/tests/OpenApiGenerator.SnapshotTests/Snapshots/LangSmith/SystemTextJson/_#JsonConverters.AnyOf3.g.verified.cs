//HintName: JsonConverters.AnyOf3.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public class AnyOfJsonConverter<T1, T2, T3> : global::System.Text.Json.Serialization.JsonConverter<global::System.AnyOf<T1, T2, T3>>
    {
        public override global::System.AnyOf<T1, T2, T3> Read(
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
            var result = new global::System.AnyOf<T1, T2, T3>(
                value1,

                value2,

                value3
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for AnyOf<{typeof(T1).Name}, {typeof(T2).Name}, {typeof(T3).Name}>");
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
            return result;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::System.AnyOf<T1, T2, T3> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid AnyOf<{typeof(T1).Name}, {typeof(T2).Name}, {typeof(T3).Name}> object.");
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
        }
    }
}