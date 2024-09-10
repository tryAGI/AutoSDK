//HintName: JsonConverters.AnyOf1.g.cs
#nullable enable

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public class AnyOfJsonConverter<T1> : global::System.Text.Json.Serialization.JsonConverter<global::G.AnyOf<T1>>
    {
        /// <inheritdoc />
        public override global::G.AnyOf<T1> Read(
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

            var result = new global::G.AnyOf<T1>(
                value1
                );

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T1>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnyOf<T1> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(T1), options);
            }
        }
    }
}