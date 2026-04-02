//HintName: G.JsonConverters.PostDialDigitsVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PostDialDigitsVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostDialDigitsVariant1>
    {
        /// <inheritdoc />
        public override global::G.PostDialDigitsVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PhoneNumberTransferPostDialDigitsVariant1Discriminator>(ref readerCopy, options);

            global::G.PostDialDigitsStatic? @static = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType.Static)
            {
                @static = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PostDialDigitsStatic>(ref reader, options);
            }
            global::G.PostDialDigitsDynamicVariable? dynamic = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType.Dynamic)
            {
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PostDialDigitsDynamicVariable>(ref reader, options);
            }

            var __value = new global::G.PostDialDigitsVariant1(
                discriminator?.Type,
                @static,

                dynamic
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostDialDigitsVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStatic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Static, typeof(global::G.PostDialDigitsStatic), options);
            }
            else if (value.IsDynamic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeof(global::G.PostDialDigitsDynamicVariable), options);
            }
        }
    }
}