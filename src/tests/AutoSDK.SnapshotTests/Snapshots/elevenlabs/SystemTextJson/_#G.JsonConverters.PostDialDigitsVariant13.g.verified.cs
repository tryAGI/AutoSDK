//HintName: G.JsonConverters.PostDialDigitsVariant13.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PostDialDigitsVariant13JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostDialDigitsVariant13>
    {
        /// <inheritdoc />
        public override global::G.PostDialDigitsVariant13 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PostDialDigitsStatic? @static = default;
            if (discriminator?.Type == global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType.Static)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PostDialDigitsStatic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PostDialDigitsStatic> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PostDialDigitsStatic)}");
                @static = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PostDialDigitsDynamicVariable? dynamic = default;
            if (discriminator?.Type == global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PostDialDigitsDynamicVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PostDialDigitsDynamicVariable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PostDialDigitsDynamicVariable)}");
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.PostDialDigitsVariant13(
                discriminator?.Type,
                @static,

                dynamic
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostDialDigitsVariant13 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStatic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PostDialDigitsStatic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PostDialDigitsStatic?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PostDialDigitsStatic).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Static, typeInfo);
            }
            else if (value.IsDynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PostDialDigitsDynamicVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PostDialDigitsDynamicVariable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PostDialDigitsDynamicVariable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeInfo);
            }
        }
    }
}