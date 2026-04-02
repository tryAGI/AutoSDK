//HintName: G.JsonConverters.InsightControllerCreateRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerCreateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InsightControllerCreateRequest>
    {
        /// <inheritdoc />
        public override global::G.InsightControllerCreateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InsightControllerCreateRequestDiscriminator>(ref readerCopy, options);

            global::G.CreateBarInsightFromCallTableDTO? bar = default;
            if (discriminator?.Type == global::G.InsightControllerCreateRequestDiscriminatorType.Bar)
            {
                bar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateBarInsightFromCallTableDTO>(ref reader, options);
            }
            global::G.CreatePieInsightFromCallTableDTO? pie = default;
            if (discriminator?.Type == global::G.InsightControllerCreateRequestDiscriminatorType.Pie)
            {
                pie = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreatePieInsightFromCallTableDTO>(ref reader, options);
            }
            global::G.CreateLineInsightFromCallTableDTO? line = default;
            if (discriminator?.Type == global::G.InsightControllerCreateRequestDiscriminatorType.Line)
            {
                line = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateLineInsightFromCallTableDTO>(ref reader, options);
            }
            global::G.CreateTextInsightFromCallTableDTO? text = default;
            if (discriminator?.Type == global::G.InsightControllerCreateRequestDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTextInsightFromCallTableDTO>(ref reader, options);
            }

            var __value = new global::G.InsightControllerCreateRequest(
                discriminator?.Type,
                bar,

                pie,

                line,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InsightControllerCreateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar, typeof(global::G.CreateBarInsightFromCallTableDTO), options);
            }
            else if (value.IsPie)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie, typeof(global::G.CreatePieInsightFromCallTableDTO), options);
            }
            else if (value.IsLine)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeof(global::G.CreateLineInsightFromCallTableDTO), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.CreateTextInsightFromCallTableDTO), options);
            }
        }
    }
}