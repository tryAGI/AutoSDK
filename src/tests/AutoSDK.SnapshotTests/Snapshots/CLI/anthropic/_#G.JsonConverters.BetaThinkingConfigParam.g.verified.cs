//HintName: G.JsonConverters.BetaThinkingConfigParam.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BetaThinkingConfigParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BetaThinkingConfigParam>
    {
        /// <inheritdoc />
        public override global::G.BetaThinkingConfigParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaThinkingConfigParamDiscriminator>(ref readerCopy, options);

            global::G.BetaThinkingConfigEnabled? enabled = default;
            if (discriminator?.Type == global::G.BetaThinkingConfigParamDiscriminatorType.Enabled)
            {
                enabled = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaThinkingConfigEnabled>(ref reader, options);
            }
            global::G.BetaThinkingConfigDisabled? disabled = default;
            if (discriminator?.Type == global::G.BetaThinkingConfigParamDiscriminatorType.Disabled)
            {
                disabled = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaThinkingConfigDisabled>(ref reader, options);
            }

            var __value = new global::G.BetaThinkingConfigParam(
                discriminator?.Type,
                enabled,

                disabled
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BetaThinkingConfigParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEnabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enabled, typeof(global::G.BetaThinkingConfigEnabled), options);
            }
            else if (value.IsDisabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeof(global::G.BetaThinkingConfigDisabled), options);
            }
        }
    }
}