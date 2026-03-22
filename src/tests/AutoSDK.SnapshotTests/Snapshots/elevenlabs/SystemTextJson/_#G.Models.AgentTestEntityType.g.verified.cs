//HintName: G.Models.AgentTestEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentTestEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Folder,
        /// <summary>
        /// 
        /// </summary>
        Test,
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
                AgentTestEntityType.Folder => "folder",
                AgentTestEntityType.Test => "test",
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
                "folder" => AgentTestEntityType.Folder,
                "test" => AgentTestEntityType.Test,
                _ => null,
            };
        }
    }
}