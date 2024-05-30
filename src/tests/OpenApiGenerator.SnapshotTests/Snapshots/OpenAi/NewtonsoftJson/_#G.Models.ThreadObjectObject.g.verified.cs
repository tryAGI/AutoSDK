//HintName: G.Models.ThreadObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ThreadObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread")]
        Thread,
    }

    public static class ThreadObjectObjectExtensions
    {
        public static string ToValueString(this ThreadObjectObject value)
        {
            return value switch
            {
                ThreadObjectObject.Thread => "thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ThreadObjectObject ToEnum(string value)
        {
            return value switch
            {
                "thread" => ThreadObjectObject.Thread,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ThreadObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => ThreadObjectObject.Thread,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}