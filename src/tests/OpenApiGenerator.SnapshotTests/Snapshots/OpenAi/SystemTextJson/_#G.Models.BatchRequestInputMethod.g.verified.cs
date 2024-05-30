//HintName: G.Models.BatchRequestInputMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to be used for the request. Currently only `POST` is supported.
    /// </summary>
    public enum BatchRequestInputMethod
    {
        /// <summary>
        /// 
        /// </summary>
        POST,
    }

    public static class BatchRequestInputMethodExtensions
    {
        public static string ToValueString(this BatchRequestInputMethod value)
        {
            return value switch
            {
                BatchRequestInputMethod.POST => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static BatchRequestInputMethod ToEnum(string value)
        {
            return value switch
            {
                "POST" => BatchRequestInputMethod.POST,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static BatchRequestInputMethod ToEnum(int value)
        {
            return value switch
            {
                0 => BatchRequestInputMethod.POST,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}