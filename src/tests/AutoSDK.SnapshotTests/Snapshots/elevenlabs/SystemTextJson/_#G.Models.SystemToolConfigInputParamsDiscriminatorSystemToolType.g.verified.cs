//HintName: G.Models.SystemToolConfigInputParamsDiscriminatorSystemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SystemToolConfigInputParamsDiscriminatorSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentPromptChange,
        /// <summary>
        /// 
        /// </summary>
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        LanguageDetection,
        /// <summary>
        /// 
        /// </summary>
        MemoryEntryCreate,
        /// <summary>
        /// 
        /// </summary>
        MemoryEntryDelete,
        /// <summary>
        /// 
        /// </summary>
        MemoryEntrySearch,
        /// <summary>
        /// 
        /// </summary>
        MemoryEntryUpdate,
        /// <summary>
        /// 
        /// </summary>
        PlayKeypadTouchTone,
        /// <summary>
        /// 
        /// </summary>
        SkipTurn,
        /// <summary>
        /// 
        /// </summary>
        TransferToAgent,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumber,
        /// <summary>
        /// 
        /// </summary>
        VoicemailDetection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemToolConfigInputParamsDiscriminatorSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemToolConfigInputParamsDiscriminatorSystemToolType value)
        {
            return value switch
            {
                SystemToolConfigInputParamsDiscriminatorSystemToolType.AgentPromptChange => "agent_prompt_change",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.EndCall => "end_call",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.LanguageDetection => "language_detection",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryCreate => "memory_entry_create",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryDelete => "memory_entry_delete",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntrySearch => "memory_entry_search",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryUpdate => "memory_entry_update",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone => "play_keypad_touch_tone",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.SkipTurn => "skip_turn",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToAgent => "transfer_to_agent",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToNumber => "transfer_to_number",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.VoicemailDetection => "voicemail_detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemToolConfigInputParamsDiscriminatorSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "agent_prompt_change" => SystemToolConfigInputParamsDiscriminatorSystemToolType.AgentPromptChange,
                "end_call" => SystemToolConfigInputParamsDiscriminatorSystemToolType.EndCall,
                "language_detection" => SystemToolConfigInputParamsDiscriminatorSystemToolType.LanguageDetection,
                "memory_entry_create" => SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryCreate,
                "memory_entry_delete" => SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryDelete,
                "memory_entry_search" => SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntrySearch,
                "memory_entry_update" => SystemToolConfigInputParamsDiscriminatorSystemToolType.MemoryEntryUpdate,
                "play_keypad_touch_tone" => SystemToolConfigInputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone,
                "skip_turn" => SystemToolConfigInputParamsDiscriminatorSystemToolType.SkipTurn,
                "transfer_to_agent" => SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToAgent,
                "transfer_to_number" => SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToNumber,
                "voicemail_detection" => SystemToolConfigInputParamsDiscriminatorSystemToolType.VoicemailDetection,
                _ => null,
            };
        }
    }
}