//HintName: G.Models.RunObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread.run`.
    /// </summary>
    public enum RunObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        Threadrun,
    }

    public static class RunObjectObjectExtensions
    {
        public static string ToValueString(this RunObjectObject value)
        {
            return value switch
            {
                RunObjectObject.Threadrun => "thread.run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectObject ToEnum(string value)
        {
            return value switch
            {
                "thread.run" => RunObjectObject.Threadrun,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => RunObjectObject.Threadrun,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}