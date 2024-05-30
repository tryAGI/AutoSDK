//HintName: G.Models.RunStepDetailsToolCallsFileSearchObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool call. This is always going to be `file_search` for this type of tool call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDetailsToolCallsFileSearchObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search")]
        FileSearch,
    }

    public static class RunStepDetailsToolCallsFileSearchObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDetailsToolCallsFileSearchObjectType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsFileSearchObjectType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsFileSearchObjectType ToEnum(string value)
        {
            return value switch
            {
                "file_search" => RunStepDetailsToolCallsFileSearchObjectType.FileSearch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsFileSearchObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDetailsToolCallsFileSearchObjectType.FileSearch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}