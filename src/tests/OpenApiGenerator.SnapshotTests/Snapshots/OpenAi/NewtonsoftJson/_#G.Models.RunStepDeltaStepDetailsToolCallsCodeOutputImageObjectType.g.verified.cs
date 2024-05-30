//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `image`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
    }

    public static class RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType ToEnum(string value)
        {
            return value switch
            {
                "image" => RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType.Image,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType.Image,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}