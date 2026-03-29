//HintName: G.Models.CreateSmsChatResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSmsChatResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSmsChatResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSmsChatResponseStatus2 value)
        {
            return value switch
            {
                CreateSmsChatResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSmsChatResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateSmsChatResponseStatus2.Error,
                _ => null,
            };
        }
    }
}