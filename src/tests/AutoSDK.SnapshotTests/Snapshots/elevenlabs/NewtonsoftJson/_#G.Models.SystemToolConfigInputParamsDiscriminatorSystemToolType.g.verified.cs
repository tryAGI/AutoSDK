//HintName: G.Models.SystemToolConfigInputParamsDiscriminatorSystemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SystemToolConfigInputParamsDiscriminatorSystemToolType
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