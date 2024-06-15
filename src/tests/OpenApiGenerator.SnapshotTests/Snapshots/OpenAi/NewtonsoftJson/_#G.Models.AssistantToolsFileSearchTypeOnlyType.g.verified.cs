//HintName: G.Models.AssistantToolsFileSearchTypeOnlyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool being defined: `file_search`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantToolsFileSearchTypeOnlyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search")]
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantToolsFileSearchTypeOnlyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantToolsFileSearchTypeOnlyType value)
        {
            return value switch
            {
                AssistantToolsFileSearchTypeOnlyType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantToolsFileSearchTypeOnlyType? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => AssistantToolsFileSearchTypeOnlyType.FileSearch,
                _ => null,
            };
        }
    }
}