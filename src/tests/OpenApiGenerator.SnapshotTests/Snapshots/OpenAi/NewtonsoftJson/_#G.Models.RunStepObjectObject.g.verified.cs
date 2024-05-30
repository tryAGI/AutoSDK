//HintName: G.Models.RunStepObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread.run.step`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step")]
        Threadrunstep,
    }

    public static class RunStepObjectObjectExtensions
    {
        public static string ToValueString(this RunStepObjectObject value)
        {
            return value switch
            {
                RunStepObjectObject.Threadrunstep => "thread.run.step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepObjectObject ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step" => RunStepObjectObject.Threadrunstep,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepObjectObject.Threadrunstep,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}