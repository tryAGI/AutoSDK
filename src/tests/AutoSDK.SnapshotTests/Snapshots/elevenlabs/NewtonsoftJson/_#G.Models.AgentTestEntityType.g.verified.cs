//HintName: G.Models.AgentTestEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentTestEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="test")]
        Test,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="folder")]
        Folder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestEntityType value)
        {
            return value switch
            {
                AgentTestEntityType.Test => "test",
                AgentTestEntityType.Folder => "folder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestEntityType? ToEnum(string value)
        {
            return value switch
            {
                "test" => AgentTestEntityType.Test,
                "folder" => AgentTestEntityType.Folder,
                _ => null,
            };
        }
    }
}