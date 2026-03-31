//HintName: G.Models.CreateResponseResponseTruncation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The truncation strategy used.
    /// </summary>
    public enum CreateResponseResponseTruncation
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseResponseTruncationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseResponseTruncation value)
        {
            return value switch
            {
                CreateResponseResponseTruncation.Auto => "auto",
                CreateResponseResponseTruncation.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseResponseTruncation? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateResponseResponseTruncation.Auto,
                "disabled" => CreateResponseResponseTruncation.Disabled,
                _ => null,
            };
        }
    }
}