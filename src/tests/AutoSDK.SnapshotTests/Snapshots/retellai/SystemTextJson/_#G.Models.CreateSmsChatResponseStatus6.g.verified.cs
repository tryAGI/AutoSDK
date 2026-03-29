//HintName: G.Models.CreateSmsChatResponseStatus6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSmsChatResponseStatus6
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSmsChatResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSmsChatResponseStatus6 value)
        {
            return value switch
            {
                CreateSmsChatResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSmsChatResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateSmsChatResponseStatus6.Error,
                _ => null,
            };
        }
    }
}