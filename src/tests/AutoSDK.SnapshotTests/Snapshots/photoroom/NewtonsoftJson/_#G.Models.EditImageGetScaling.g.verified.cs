//HintName: G.Models.EditImageGetScaling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: fit
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetScaling
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