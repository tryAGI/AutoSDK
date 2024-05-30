//HintName: G.Models.AssistantToolsFileSearchType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool being defined: `file_search`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantToolsFileSearchType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search")]
        FileSearch,
    }

    public static class AssistantToolsFileSearchTypeExtensions
    {
        public static string ToValueString(this AssistantToolsFileSearchType value)
        {
            return value switch
            {
                AssistantToolsFileSearchType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantToolsFileSearchType ToEnum(string value)
        {
            return value switch
            {
                "file_search" => AssistantToolsFileSearchType.FileSearch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantToolsFileSearchType ToEnum(int value)
        {
            return value switch
            {
                0 => AssistantToolsFileSearchType.FileSearch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}