//HintName: G.Models.CreateGenerationRequestTransparency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which type of transparency this image should use
    /// </summary>
    public enum CreateGenerationRequestTransparency
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        ForegroundOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerationRequestTransparencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerationRequestTransparency value)
        {
            return value switch
            {
                CreateGenerationRequestTransparency.Disabled => "disabled",
                CreateGenerationRequestTransparency.ForegroundOnly => "foreground_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerationRequestTransparency? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CreateGenerationRequestTransparency.Disabled,
                "foreground_only" => CreateGenerationRequestTransparency.ForegroundOnly,
                _ => null,
            };
        }
    }
}