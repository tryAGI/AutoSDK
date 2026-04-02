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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SystemToolConfigInputParamsDiscriminator>(ref readerCopy, options);

            global::G.EndCallToolConfig? endCall = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EndCallToolConfig>(ref reader, options);
            }
            global::G.LanguageDetectionToolConfig? languageDetection = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.LanguageDetection)
            {
                languageDetection = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LanguageDetectionToolConfig>(ref reader, options);
            }
            global::G.TransferToAgentToolConfig? transferToAgent = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToAgent)
            {
                transferToAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferToAgentToolConfig>(ref reader, options);
            }
            global::G.TransferToNumberToolConfigInput? transferToNumber = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToNumber)
            {
                transferToNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferToNumberToolConfigInput>(ref reader, options);
            }
            global::G.SkipTurnToolConfig? skipTurn = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.SkipTurn)
            {
                skipTurn = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SkipTurnToolConfig>(ref reader, options);
            }
            global::G.PlayDTMFToolConfig? playKeypadTouchTone = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone)
            {
                playKeypadTouchTone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PlayDTMFToolConfig>(ref reader, options);
            }
            global::G.VoicemailDetectionToolConfig? voicemailDetection = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.VoicemailDetection)
            {
                voicemailDetection = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VoicemailDetectionToolConfig>(ref reader, options);
            }
            global::G.MemoryEntrySearchToolConfig? memoryEntrySearch = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntrySearch)
            {
                memoryEntrySearch = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MemoryEntrySearchToolConfig>(ref reader, options);
            }
            global::G.MemoryEntryCreateToolConfig? memoryEntryCreate = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryCreate)
            {
                memoryEntryCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MemoryEntryCreateToolConfig>(ref reader, options);
            }
            global::G.MemoryEntryUpdateToolConfig? memoryEntryUpdate = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryUpdate)
            {
                memoryEntryUpdate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MemoryEntryUpdateToolConfig>(ref reader, options);
            }
            global::G.MemoryEntryDeleteToolConfig? memoryEntryDelete = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryDelete)
            {
                memoryEntryDelete = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MemoryEntryDeleteToolConfig>(ref reader, options);
            }
            global::G.AgentPromptChangeToolConfig? agentPromptChange = default;
            if (discriminator?.SystemToolType == global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType.AgentPromptChange)
            {
                agentPromptChange = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentPromptChangeToolConfig>(ref reader, options);
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

            if (value.IsEndCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeof(global::G.EndCallToolConfig), options);
            }
            else if (value.IsLanguageDetection)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LanguageDetection, typeof(global::G.LanguageDetectionToolConfig), options);
            }
            else if (value.IsTransferToAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgent, typeof(global::G.TransferToAgentToolConfig), options);
            }
            else if (value.IsTransferToNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumber, typeof(global::G.TransferToNumberToolConfigInput), options);
            }
            else if (value.IsSkipTurn)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkipTurn, typeof(global::G.SkipTurnToolConfig), options);
            }
            else if (value.IsPlayKeypadTouchTone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayKeypadTouchTone, typeof(global::G.PlayDTMFToolConfig), options);
            }
            else if (value.IsVoicemailDetection)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoicemailDetection, typeof(global::G.VoicemailDetectionToolConfig), options);
            }
            else if (value.IsMemoryEntrySearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryEntrySearch, typeof(global::G.MemoryEntrySearchToolConfig), options);
            }
            else if (value.IsMemoryEntryCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryEntryCreate, typeof(global::G.MemoryEntryCreateToolConfig), options);
            }
            else if (value.IsMemoryEntryUpdate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryEntryUpdate, typeof(global::G.MemoryEntryUpdateToolConfig), options);
            }
            else if (value.IsMemoryEntryDelete)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryEntryDelete, typeof(global::G.MemoryEntryDeleteToolConfig), options);
            }
            else if (value.IsAgentPromptChange)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentPromptChange, typeof(global::G.AgentPromptChangeToolConfig), options);
            }
        }
    }
}