//HintName: G.JsonConverters.Params2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Params2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Params2>
    {
        /// <inheritdoc />
        public override global::G.Params2 Read(
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
            global::G.TransferToNumberToolConfigInput? transferToNumber = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberToolConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferToNumberToolConfigInput)}");
                transferToNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SkipTurnToolConfig? skipTurn = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.SkipTurn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SkipTurnToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SkipTurnToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SkipTurnToolConfig)}");
                skipTurn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PlayDTMFToolConfig? playKeypadTouchTone = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlayDTMFToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlayDTMFToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PlayDTMFToolConfig)}");
                playKeypadTouchTone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VoicemailDetectionToolConfig? voicemailDetection = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.VoicemailDetection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoicemailDetectionToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoicemailDetectionToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VoicemailDetectionToolConfig)}");
                voicemailDetection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MemoryEntrySearchToolConfig? memoryEntrySearch = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntrySearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MemoryEntrySearchToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MemoryEntrySearchToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MemoryEntrySearchToolConfig)}");
                memoryEntrySearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MemoryEntryCreateToolConfig? memoryEntryCreate = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MemoryEntryCreateToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MemoryEntryCreateToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MemoryEntryCreateToolConfig)}");
                memoryEntryCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MemoryEntryUpdateToolConfig? memoryEntryUpdate = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MemoryEntryUpdateToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MemoryEntryUpdateToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MemoryEntryUpdateToolConfig)}");
                memoryEntryUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MemoryEntryDeleteToolConfig? memoryEntryDelete = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryDelete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MemoryEntryDeleteToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MemoryEntryDeleteToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MemoryEntryDeleteToolConfig)}");
                memoryEntryDelete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AgentPromptChangeToolConfig? agentPromptChange = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.AgentPromptChange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPromptChangeToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPromptChangeToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentPromptChangeToolConfig)}");
                agentPromptChange = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Params2(
                discriminator?.SystemToolType,
                endCall,

                languageDetection,

                transferToAgent,

                transferToNumber,

                skipTurn,

                playKeypadTouchTone,

                voicemailDetection,

                memoryEntrySearch,

                memoryEntryCreate,

                memoryEntryUpdate,

                memoryEntryDelete,

                agentPromptChange
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Params2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EndCallToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall!, typeInfo);
            }
            else if (value.IsLanguageDetection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LanguageDetectionToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LanguageDetectionToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LanguageDetectionToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LanguageDetection!, typeInfo);
            }
            else if (value.IsTransferToAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToAgentToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToAgentToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferToAgentToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgent!, typeInfo);
            }
            else if (value.IsTransferToNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberToolConfigInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferToNumberToolConfigInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumber!, typeInfo);
            }
            else if (value.IsSkipTurn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SkipTurnToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SkipTurnToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SkipTurnToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkipTurn!, typeInfo);
            }
            else if (value.IsPlayKeypadTouchTone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlayDTMFToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlayDTMFToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PlayDTMFToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayKeypadTouchTone!, typeInfo);
            }
            else if (value.IsVoicemailDetection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoicemailDetectionToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoicemailDetectionToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VoicemailDetectionToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoicemailDetection!, typeInfo);
            }
            else if (value.IsMemoryEntrySearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MemoryEntrySearchToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MemoryEntrySearchToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MemoryEntrySearchToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryEntrySearch!, typeInfo);
            }
            else if (value.IsMemoryEntryCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MemoryEntryCreateToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MemoryEntryCreateToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MemoryEntryCreateToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryEntryCreate!, typeInfo);
            }
            else if (value.IsMemoryEntryUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MemoryEntryUpdateToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MemoryEntryUpdateToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MemoryEntryUpdateToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryEntryUpdate!, typeInfo);
            }
            else if (value.IsMemoryEntryDelete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MemoryEntryDeleteToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MemoryEntryDeleteToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MemoryEntryDeleteToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryEntryDelete!, typeInfo);
            }
            else if (value.IsAgentPromptChange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPromptChangeToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPromptChangeToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPromptChangeToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentPromptChange!, typeInfo);
            }
        }
    }
}