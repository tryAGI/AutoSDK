﻿//HintName: G.Models.RunStepDeltaObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread.run.step.delta`.
    /// </summary>
    public enum RunStepDeltaObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDeltaObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDeltaObjectObject value)
        {
            return value switch
            {
                RunStepDeltaObjectObject.ThreadRunStepDelta => "thread.run.step.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDeltaObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.delta" => RunStepDeltaObjectObject.ThreadRunStepDelta,
                _ => null,
            };
        }
    }
}