//HintName: G.Models.RunStepObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread.run.step`.
    /// </summary>
    public enum RunStepObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        Threadrunstep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepObjectObject value)
        {
            return value switch
            {
                RunStepObjectObject.Threadrunstep => "thread.run.step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step" => RunStepObjectObject.Threadrunstep,
                _ => null,
            };
        }
    }
}