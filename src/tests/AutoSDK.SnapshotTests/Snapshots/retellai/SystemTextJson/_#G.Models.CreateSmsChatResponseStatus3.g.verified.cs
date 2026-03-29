//HintName: G.Models.CreateSmsChatResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSmsChatResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSmsChatResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSmsChatResponseStatus3 value)
        {
            return value switch
            {
                CreateSmsChatResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSmsChatResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateSmsChatResponseStatus3.Error,
                _ => null,
            };
        }
    }
}