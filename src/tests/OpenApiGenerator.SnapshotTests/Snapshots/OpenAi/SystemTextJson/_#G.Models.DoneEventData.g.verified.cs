//HintName: G.Models.DoneEventData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DoneEventData
    {
        /// <summary>
        /// 
        /// </summary>
        DONE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DoneEventDataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DoneEventData value)
        {
            return value switch
            {
                DoneEventData.DONE => "[DONE]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DoneEventData ToEnum(string value)
        {
            return value switch
            {
                "[DONE]" => DoneEventData.DONE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}