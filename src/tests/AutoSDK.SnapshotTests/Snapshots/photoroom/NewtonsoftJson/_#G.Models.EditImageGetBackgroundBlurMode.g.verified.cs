//HintName: G.Models.EditImageGetBackgroundBlurMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetBackgroundBlurMode
    {
        /// <summary>
        /// Applies a bokeh blur to the background.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bokeh")]
        Bokeh,
        /// <summary>
        /// Applies a gaussian blur to the background.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gaussian")]
        Gaussian,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetBackgroundBlurModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetBackgroundBlurMode value)
        {
            return value switch
            {
                EditImageGetBackgroundBlurMode.Bokeh => "bokeh",
                EditImageGetBackgroundBlurMode.Gaussian => "gaussian",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetBackgroundBlurMode? ToEnum(string value)
        {
            return value switch
            {
                "bokeh" => EditImageGetBackgroundBlurMode.Bokeh,
                "gaussian" => EditImageGetBackgroundBlurMode.Gaussian,
                _ => null,
            };
        }
    }
}