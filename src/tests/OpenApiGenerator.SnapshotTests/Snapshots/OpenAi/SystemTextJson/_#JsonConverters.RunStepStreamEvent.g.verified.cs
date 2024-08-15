//HintName: JsonConverters.RunStepStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::G.RunStepStreamEventVariant1? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant1>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant2? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant2>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant3? value3 = default;
            try
            {
                value3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant3>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant4? value4 = default;
            try
            {
                value4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant4>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant5? value5 = default;
            try
            {
                value5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant5>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant6? value6 = default;
            try
            {
                value6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant6>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEventVariant7? value7 = default;
            try
            {
                value7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant7>(ref readerCopy, options);
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
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant1>(ref reader, options);
            }
            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant2>(ref reader, options);
            }
            else if (value3 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant3>(ref reader, options);
            }
            else if (value4 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant4>(ref reader, options);
            }
            else if (value5 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant5>(ref reader, options);
            }
            else if (value6 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant6>(ref reader, options);
            }
            else if (value7 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEventVariant7>(ref reader, options);
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

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(global::G.RunStepStreamEventVariant1), options);
            }
            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(global::G.RunStepStreamEventVariant2), options);
            }
            else if (value.IsValue3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeof(global::G.RunStepStreamEventVariant3), options);
            }
            else if (value.IsValue4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeof(global::G.RunStepStreamEventVariant4), options);
            }
            else if (value.IsValue5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeof(global::G.RunStepStreamEventVariant5), options);
            }
            else if (value.IsValue6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeof(global::G.RunStepStreamEventVariant6), options);
            }
            else if (value.IsValue7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeof(global::G.RunStepStreamEventVariant7), options);
            }
        }
    }
}