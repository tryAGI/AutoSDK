﻿//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `image`.
    /// </summary>
    public enum RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image" => RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType.Image,
                _ => null,
            };
        }
    }
}