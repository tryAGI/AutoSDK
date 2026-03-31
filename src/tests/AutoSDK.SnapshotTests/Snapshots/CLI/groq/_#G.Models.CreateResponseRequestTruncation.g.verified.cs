//HintName: G.Models.CreateResponseRequestTruncation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Context truncation strategy. Supported values: `auto` or `disabled`.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CreateResponseRequestTruncation
    {
        /// <summary>
        /// `auto` or `disabled`.
        /// </summary>
        Auto,
        /// <summary>
        /// `auto` or `disabled`.
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseRequestTruncationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseRequestTruncation value)
        {
            return value switch
            {
                CreateResponseRequestTruncation.Auto => "auto",
                CreateResponseRequestTruncation.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseRequestTruncation? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateResponseRequestTruncation.Auto,
                "disabled" => CreateResponseRequestTruncation.Disabled,
                _ => null,
            };
        }
    }
}