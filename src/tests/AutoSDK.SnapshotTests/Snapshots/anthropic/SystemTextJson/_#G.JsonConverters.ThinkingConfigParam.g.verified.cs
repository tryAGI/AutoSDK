//HintName: G.JsonConverters.ThinkingConfigParam.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ThinkingConfigParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ThinkingConfigParam>
    {
        /// <inheritdoc />
        public override global::G.ThinkingConfigParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ThinkingConfigParamDiscriminator>(ref readerCopy, options);

            global::G.ThinkingConfigEnabled? enabled = default;
            if (discriminator?.Type == global::G.ThinkingConfigParamDiscriminatorType.Enabled)
            {
                enabled = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ThinkingConfigEnabled>(ref reader, options);
            }
            global::G.ThinkingConfigDisabled? disabled = default;
            if (discriminator?.Type == global::G.ThinkingConfigParamDiscriminatorType.Disabled)
            {
                disabled = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ThinkingConfigDisabled>(ref reader, options);
            }

            var __value = new global::G.ThinkingConfigParam(
                discriminator?.Type,
                enabled,

                disabled
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ThinkingConfigParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEnabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enabled, typeof(global::G.ThinkingConfigEnabled), options);
            }
            else if (value.IsDisabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeof(global::G.ThinkingConfigDisabled), options);
            }
        }
    }
}