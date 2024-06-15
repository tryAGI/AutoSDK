//HintName: JsonConverters.RunStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::G.RunStreamEventVariant1? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant1>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant2? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant2>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant3? value3 = default;
            try
            {
                value3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant3>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant4? value4 = default;
            try
            {
                value4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant4>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant5? value5 = default;
            try
            {
                value5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant5>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant6? value6 = default;
            try
            {
                value6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant6>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant7? value7 = default;
            try
            {
                value7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant7>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant8? value8 = default;
            try
            {
                value8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant8>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant9? value9 = default;
            try
            {
                value9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant9>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEventVariant10? value10 = default;
            try
            {
                value10 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant10>(ref readerCopy, options);
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
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::G.RunStreamEventVariant1).Name}, {typeof(global::G.RunStreamEventVariant2).Name}, {typeof(global::G.RunStreamEventVariant3).Name}, {typeof(global::G.RunStreamEventVariant4).Name}, {typeof(global::G.RunStreamEventVariant5).Name}, {typeof(global::G.RunStreamEventVariant6).Name}, {typeof(global::G.RunStreamEventVariant7).Name}, {typeof(global::G.RunStreamEventVariant8).Name}, {typeof(global::G.RunStreamEventVariant9).Name}, {typeof(global::G.RunStreamEventVariant10).Name}>");
            }

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant1>(ref reader, options);
            }

            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant2>(ref reader, options);
            }

            else if (value3 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant3>(ref reader, options);
            }

            else if (value4 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant4>(ref reader, options);
            }

            else if (value5 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant5>(ref reader, options);
            }

            else if (value6 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant6>(ref reader, options);
            }

            else if (value7 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant7>(ref reader, options);
            }

            else if (value8 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant8>(ref reader, options);
            }

            else if (value9 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant9>(ref reader, options);
            }

            else if (value10 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEventVariant10>(ref reader, options);
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

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::G.RunStreamEventVariant1).Name}, {typeof(global::G.RunStreamEventVariant2).Name}, {typeof(global::G.RunStreamEventVariant3).Name}, {typeof(global::G.RunStreamEventVariant4).Name}, {typeof(global::G.RunStreamEventVariant5).Name}, {typeof(global::G.RunStreamEventVariant6).Name}, {typeof(global::G.RunStreamEventVariant7).Name}, {typeof(global::G.RunStreamEventVariant8).Name}, {typeof(global::G.RunStreamEventVariant9).Name}, {typeof(global::G.RunStreamEventVariant10).Name}> object.");
            }

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(global::G.RunStreamEventVariant1), options);
            }

            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(global::G.RunStreamEventVariant2), options);
            }

            else if (value.IsValue3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeof(global::G.RunStreamEventVariant3), options);
            }

            else if (value.IsValue4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeof(global::G.RunStreamEventVariant4), options);
            }

            else if (value.IsValue5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeof(global::G.RunStreamEventVariant5), options);
            }

            else if (value.IsValue6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeof(global::G.RunStreamEventVariant6), options);
            }

            else if (value.IsValue7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeof(global::G.RunStreamEventVariant7), options);
            }

            else if (value.IsValue8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeof(global::G.RunStreamEventVariant8), options);
            }

            else if (value.IsValue9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeof(global::G.RunStreamEventVariant9), options);
            }

            else if (value.IsValue10)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeof(global::G.RunStreamEventVariant10), options);
            }
        }
    }
}