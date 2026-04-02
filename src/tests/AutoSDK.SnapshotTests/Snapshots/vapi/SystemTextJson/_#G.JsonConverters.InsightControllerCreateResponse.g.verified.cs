//HintName: G.JsonConverters.InsightControllerCreateResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerCreateResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InsightControllerCreateResponse>
    {
        /// <inheritdoc />
        public override global::G.InsightControllerCreateResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InsightControllerCreateResponseDiscriminator>(ref readerCopy, options);

            global::G.BarInsight? bar = default;
            if (discriminator?.Type == global::G.InsightControllerCreateResponseDiscriminatorType.Bar)
            {
                bar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BarInsight>(ref reader, options);
            }
            global::G.PieInsight? pie = default;
            if (discriminator?.Type == global::G.InsightControllerCreateResponseDiscriminatorType.Pie)
            {
                pie = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PieInsight>(ref reader, options);
            }
            global::G.LineInsight? line = default;
            if (discriminator?.Type == global::G.InsightControllerCreateResponseDiscriminatorType.Line)
            {
                line = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LineInsight>(ref reader, options);
            }
            global::G.TextInsight? text = default;
            if (discriminator?.Type == global::G.InsightControllerCreateResponseDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextInsight>(ref reader, options);
            }

            var __value = new global::G.InsightControllerCreateResponse(
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
            global::G.InsightControllerCreateResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar, typeof(global::G.BarInsight), options);
            }
            else if (value.IsPie)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie, typeof(global::G.PieInsight), options);
            }
            else if (value.IsLine)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeof(global::G.LineInsight), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextInsight), options);
            }
        }
    }
}