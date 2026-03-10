//HintName: G.Models.SystemToolConfigOutputParamsDiscriminatorSystemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SystemToolConfigOutputParamsDiscriminatorSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_prompt_change")]
        AgentPromptChange,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end_call")]
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language_detection")]
        LanguageDetection,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memory_entry_create")]
        MemoryEntryCreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memory_entry_delete")]
        MemoryEntryDelete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memory_entry_search")]
        MemoryEntrySearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memory_entry_update")]
        MemoryEntryUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="play_keypad_touch_tone")]
        PlayKeypadTouchTone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skip_turn")]
        SkipTurn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_to_agent")]
        TransferToAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_to_number")]
        TransferToNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voicemail_detection")]
        VoicemailDetection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemToolConfigOutputParamsDiscriminatorSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemToolConfigOutputParamsDiscriminatorSystemToolType value)
        {
            return value switch
            {
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.AgentPromptChange => "agent_prompt_change",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndCall => "end_call",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.LanguageDetection => "language_detection",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.MemoryEntryCreate => "memory_entry_create",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.MemoryEntryDelete => "memory_entry_delete",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.MemoryEntrySearch => "memory_entry_search",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.MemoryEntryUpdate => "memory_entry_update",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone => "play_keypad_touch_tone",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.SkipTurn => "skip_turn",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToAgent => "transfer_to_agent",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToNumber => "transfer_to_number",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.VoicemailDetection => "voicemail_detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemToolConfigOutputParamsDiscriminatorSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "agent_prompt_change" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.AgentPromptChange,
                "end_call" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndCall,
                "language_detection" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.LanguageDetection,
                "memory_entry_create" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.MemoryEntryCreate,
                "memory_entry_delete" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.MemoryEntryDelete,
                "memory_entry_search" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.MemoryEntrySearch,
                "memory_entry_update" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.MemoryEntryUpdate,
                "play_keypad_touch_tone" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone,
                "skip_turn" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.SkipTurn,
                "transfer_to_agent" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToAgent,
                "transfer_to_number" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToNumber,
                "voicemail_detection" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.VoicemailDetection,
                _ => null,
            };
        }
    }
}