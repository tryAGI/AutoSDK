//HintName: G.Models.ErrorEventEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ErrorEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    public static class ErrorEventEventExtensions
    {
        public static string ToValueString(this ErrorEventEvent value)
        {
            return value switch
            {
                ErrorEventEvent.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ErrorEventEvent ToEnum(string value)
        {
            return value switch
            {
                "error" => ErrorEventEvent.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ErrorEventEvent ToEnum(int value)
        {
            return value switch
            {
                0 => ErrorEventEvent.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}