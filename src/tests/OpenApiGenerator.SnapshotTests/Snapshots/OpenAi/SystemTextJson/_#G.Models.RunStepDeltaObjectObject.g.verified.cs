//HintName: G.Models.RunStepDeltaObjectObject.g.cs

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
        Threadrunstepdelta,
    }

    public static class RunStepDeltaObjectObjectExtensions
    {
        public static string ToValueString(this RunStepDeltaObjectObject value)
        {
            return value switch
            {
                RunStepDeltaObjectObject.Threadrunstepdelta => "thread.run.step.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaObjectObject ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.delta" => RunStepDeltaObjectObject.Threadrunstepdelta,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDeltaObjectObject.Threadrunstepdelta,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}