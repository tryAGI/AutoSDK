//HintName: G.JsonConverters.ToolChoice.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolChoice>
    {
        /// <inheritdoc />
        public override global::G.ToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolChoiceDiscriminator>(ref readerCopy, options);

            global::G.ToolChoiceAuto? auto = default;
            if (discriminator?.Type == global::G.ToolChoiceDiscriminatorType.Auto)
            {
                auto = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolChoiceAuto>(ref reader, options);
            }
            global::G.ToolChoiceAny? any = default;
            if (discriminator?.Type == global::G.ToolChoiceDiscriminatorType.Any)
            {
                any = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolChoiceAny>(ref reader, options);
            }
            global::G.ToolChoiceTool? tool = default;
            if (discriminator?.Type == global::G.ToolChoiceDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolChoiceTool>(ref reader, options);
            }

            var __value = new global::G.ToolChoice(
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
            global::G.ToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAuto)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeof(global::G.ToolChoiceAuto), options);
            }
            else if (value.IsAny)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Any, typeof(global::G.ToolChoiceAny), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.ToolChoiceTool), options);
            }
        }
    }
}