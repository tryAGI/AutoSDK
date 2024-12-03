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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadObjectObject value)
        {
            return value switch
            {
                ThreadObjectObject.Thread => "thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "thread" => ThreadObjectObject.Thread,
                _ => null,
            };
        }
    }
}