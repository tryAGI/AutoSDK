//HintName: G.Models.RunStepDeltaStepDetailsToolCallsFileSearchObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool call. This is always going to be `file_search` for this type of tool call.
    /// </summary>
    public enum RunStepDeltaStepDetailsToolCallsFileSearchObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
    }

    public static class RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsFileSearchObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsFileSearchObjectType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsFileSearchObjectType ToEnum(string value)
        {
            return value switch
            {
                "file_search" => RunStepDeltaStepDetailsToolCallsFileSearchObjectType.FileSearch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsFileSearchObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDeltaStepDetailsToolCallsFileSearchObjectType.FileSearch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}