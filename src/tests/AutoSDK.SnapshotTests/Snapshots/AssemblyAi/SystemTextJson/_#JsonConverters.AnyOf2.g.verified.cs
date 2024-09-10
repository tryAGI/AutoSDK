//HintName: JsonConverters.AnyOf2.g.cs
#nullable enable

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public class AnyOfJsonConverter<T1, T2> : global::System.Text.Json.Serialization.JsonConverter<global::G.AnyOf<T1, T2>>
    {
        /// <inheritdoc />
        public override global::G.AnyOf<T1, T2> Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            T1? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<T1>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T2? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<T2>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.AnyOf<T1, T2>(
                value1,
                value2
                );

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T1>(ref reader, options);
            }
            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T2>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnyOf<T1, T2> value,
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
        }
    }
}