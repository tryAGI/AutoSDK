//HintName: G.Models.RunGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunGroupBy value)
        {
            return value switch
            {
                RunGroupBy.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => RunGroupBy.Conversation,
                _ => null,
            };
        }
    }
}