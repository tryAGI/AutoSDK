//HintName: G.JsonConverters.InsightControllerUpdateRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerUpdateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InsightControllerUpdateRequest>
    {
        /// <inheritdoc />
        public override global::G.InsightControllerUpdateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InsightControllerUpdateRequestDiscriminator>(ref readerCopy, options);

            global::G.UpdateBarInsightFromCallTableDTO? bar = default;
            if (discriminator?.Type == global::G.InsightControllerUpdateRequestDiscriminatorType.Bar)
            {
                bar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateBarInsightFromCallTableDTO>(ref reader, options);
            }
            global::G.UpdatePieInsightFromCallTableDTO? pie = default;
            if (discriminator?.Type == global::G.InsightControllerUpdateRequestDiscriminatorType.Pie)
            {
                pie = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdatePieInsightFromCallTableDTO>(ref reader, options);
            }
            global::G.UpdateLineInsightFromCallTableDTO? line = default;
            if (discriminator?.Type == global::G.InsightControllerUpdateRequestDiscriminatorType.Line)
            {
                line = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateLineInsightFromCallTableDTO>(ref reader, options);
            }
            global::G.UpdateTextInsightFromCallTableDTO? text = default;
            if (discriminator?.Type == global::G.InsightControllerUpdateRequestDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateTextInsightFromCallTableDTO>(ref reader, options);
            }

            var __value = new global::G.InsightControllerUpdateRequest(
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
            global::G.InsightControllerUpdateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar, typeof(global::G.UpdateBarInsightFromCallTableDTO), options);
            }
            else if (value.IsPie)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie, typeof(global::G.UpdatePieInsightFromCallTableDTO), options);
            }
            else if (value.IsLine)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeof(global::G.UpdateLineInsightFromCallTableDTO), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.UpdateTextInsightFromCallTableDTO), options);
            }
        }
    }
}