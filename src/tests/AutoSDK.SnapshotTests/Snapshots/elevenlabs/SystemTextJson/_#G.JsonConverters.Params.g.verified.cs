//HintName: G.JsonConverters.Params.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Params>
    {
        /// <inheritdoc />
        public override global::G.Params Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemToolConfigInputParamsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemToolConfigInputParamsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemToolConfigInputParamsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.EndCallToolConfig? endCall = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.EndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EndCallToolConfig)}");
                endCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LanguageDetectionToolConfig? languageDetection = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.LanguageDetection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LanguageDetectionToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LanguageDetectionToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LanguageDetectionToolConfig)}");
                languageDetection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TransferToAgentToolConfig? transferToAgent = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToAgentToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToAgentToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferToAgentToolConfig)}");
                transferToAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TransferToNumberToolConfig? transferToNumber = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferToNumberToolConfig)}");
                transferToNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SkipTurnToolConfig? skipTurn = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.SkipTurn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SkipTurnToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SkipTurnToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SkipTurnToolConfig)}");
                skipTurn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Params(
                discriminator?.SystemToolType,
                endCall,
                languageDetection,
                transferToAgent,
                transferToNumber,
                skipTurn
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Params value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EndCallToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeInfo);
            }
            else if (value.IsLanguageDetection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LanguageDetectionToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LanguageDetectionToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LanguageDetectionToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LanguageDetection, typeInfo);
            }
            else if (value.IsTransferToAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToAgentToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToAgentToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferToAgentToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgent, typeInfo);
            }
            else if (value.IsTransferToNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferToNumberToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumber, typeInfo);
            }
            else if (value.IsSkipTurn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SkipTurnToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SkipTurnToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SkipTurnToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkipTurn, typeInfo);
            }
        }
    }
}