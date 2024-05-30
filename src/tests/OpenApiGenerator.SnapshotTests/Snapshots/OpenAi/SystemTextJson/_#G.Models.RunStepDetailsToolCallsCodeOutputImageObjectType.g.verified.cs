//HintName: G.Models.RunStepDetailsToolCallsCodeOutputImageObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `image`.
    /// </summary>
    public enum RunStepDetailsToolCallsCodeOutputImageObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    public static class RunStepDetailsToolCallsCodeOutputImageObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDetailsToolCallsCodeOutputImageObjectType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsCodeOutputImageObjectType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsCodeOutputImageObjectType ToEnum(string value)
        {
            return value switch
            {
                "image" => RunStepDetailsToolCallsCodeOutputImageObjectType.Image,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsCodeOutputImageObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDetailsToolCallsCodeOutputImageObjectType.Image,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}