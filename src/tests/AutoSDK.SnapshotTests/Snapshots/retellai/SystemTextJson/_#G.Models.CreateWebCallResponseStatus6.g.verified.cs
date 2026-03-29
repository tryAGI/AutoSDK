//HintName: G.Models.CreateWebCallResponseStatus6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebCallResponseStatus6
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebCallResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebCallResponseStatus6 value)
        {
            return value switch
            {
                CreateWebCallResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebCallResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateWebCallResponseStatus6.Error,
                _ => null,
            };
        }
    }
}