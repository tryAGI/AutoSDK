//HintName: G.Models.CreateImageToVideoRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation mode.<br/>
    /// Default Value: std
    /// </summary>
    public enum CreateImageToVideoRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        Pro,
        /// <summary>
        /// 
        /// </summary>
        Std,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestMode value)
        {
            return value switch
            {
                CreateImageToVideoRequestMode.Pro => "pro",
                CreateImageToVideoRequestMode.Std => "std",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "pro" => CreateImageToVideoRequestMode.Pro,
                "std" => CreateImageToVideoRequestMode.Std,
                _ => null,
            };
        }
    }
}