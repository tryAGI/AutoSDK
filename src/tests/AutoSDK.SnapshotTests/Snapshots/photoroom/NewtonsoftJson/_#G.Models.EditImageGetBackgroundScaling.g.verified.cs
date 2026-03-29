//HintName: G.Models.EditImageGetBackgroundScaling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: fill
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetBackgroundScaling
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fill")]
        Fill,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fit")]
        Fit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetBackgroundScalingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetBackgroundScaling value)
        {
            return value switch
            {
                EditImageGetBackgroundScaling.Fill => "fill",
                EditImageGetBackgroundScaling.Fit => "fit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetBackgroundScaling? ToEnum(string value)
        {
            return value switch
            {
                "fill" => EditImageGetBackgroundScaling.Fill,
                "fit" => EditImageGetBackgroundScaling.Fit,
                _ => null,
            };
        }
    }
}