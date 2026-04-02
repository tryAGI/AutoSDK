//HintName: G.JsonConverters.BetaToolChoice.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BetaToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BetaToolChoice>
    {
        /// <inheritdoc />
        public override global::G.BetaToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaToolChoiceDiscriminator>(ref readerCopy, options);

            global::G.BetaToolChoiceAuto? auto = default;
            if (discriminator?.Type == global::G.BetaToolChoiceDiscriminatorType.Auto)
            {
                auto = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaToolChoiceAuto>(ref reader, options);
            }
            global::G.BetaToolChoiceAny? any = default;
            if (discriminator?.Type == global::G.BetaToolChoiceDiscriminatorType.Any)
            {
                any = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaToolChoiceAny>(ref reader, options);
            }
            global::G.BetaToolChoiceTool? tool = default;
            if (discriminator?.Type == global::G.BetaToolChoiceDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaToolChoiceTool>(ref reader, options);
            }

            var __value = new global::G.BetaToolChoice(
                discriminator?.Type,
                auto,

                any,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BetaToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAuto)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeof(global::G.BetaToolChoiceAuto), options);
            }
            else if (value.IsAny)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Any, typeof(global::G.BetaToolChoiceAny), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.BetaToolChoiceTool), options);
            }
        }
    }
}