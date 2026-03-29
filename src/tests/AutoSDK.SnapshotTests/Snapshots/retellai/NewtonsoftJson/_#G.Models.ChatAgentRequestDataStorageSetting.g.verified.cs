//HintName: G.Models.ChatAgentRequestDataStorageSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls what data is stored for this agent. "everything" stores all data including transcripts and recordings. "everything_except_pii" stores data but excludes PII when possible based on PII configuration. "basic_attributes_only" stores only basic metadata. If not set, defaults to "everything".<br/>
    /// Example: everything
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatAgentRequestDataStorageSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic_attributes_only")]
        BasicAttributesOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="everything")]
        Everything,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="everything_except_pii")]
        EverythingExceptPii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatAgentRequestDataStorageSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatAgentRequestDataStorageSetting value)
        {
            return value switch
            {
                ChatAgentRequestDataStorageSetting.BasicAttributesOnly => "basic_attributes_only",
                ChatAgentRequestDataStorageSetting.Everything => "everything",
                ChatAgentRequestDataStorageSetting.EverythingExceptPii => "everything_except_pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatAgentRequestDataStorageSetting? ToEnum(string value)
        {
            return value switch
            {
                "basic_attributes_only" => ChatAgentRequestDataStorageSetting.BasicAttributesOnly,
                "everything" => ChatAgentRequestDataStorageSetting.Everything,
                "everything_except_pii" => ChatAgentRequestDataStorageSetting.EverythingExceptPii,
                _ => null,
            };
        }
    }
}