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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchRequestInputMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchRequestInputMethod value)
        {
            return value switch
            {
                BatchRequestInputMethod.POST => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchRequestInputMethod ToEnum(string value)
        {
            return value switch
            {
                "POST" => BatchRequestInputMethod.POST,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}