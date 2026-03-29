//HintName: G.Models.EditImageGetScaling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: fit
    /// </summary>
    public enum EditImageGetScaling
    {
        /// <summary>
        /// 
        /// </summary>
        Fill,
        /// <summary>
        /// 
        /// </summary>
        Fit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetScalingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetScaling value)
        {
            return value switch
            {
                EditImageGetScaling.Fill => "fill",
                EditImageGetScaling.Fit => "fit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetScaling? ToEnum(string value)
        {
            return value switch
            {
                "fill" => EditImageGetScaling.Fill,
                "fit" => EditImageGetScaling.Fit,
                _ => null,
            };
        }
    }
}