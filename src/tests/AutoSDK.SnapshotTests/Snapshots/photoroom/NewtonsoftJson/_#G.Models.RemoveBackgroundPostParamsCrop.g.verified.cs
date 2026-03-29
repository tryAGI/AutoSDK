//HintName: G.Models.RemoveBackgroundPostParamsCrop.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If `true`, the image returned is cropped to the cutout border. Transparent pixels are removed from the border<br/>
    /// Default Value: false
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RemoveBackgroundPostParamsCrop
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="false")]
        False,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="true")]
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveBackgroundPostParamsCropExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveBackgroundPostParamsCrop value)
        {
            return value switch
            {
                RemoveBackgroundPostParamsCrop.False => "false",
                RemoveBackgroundPostParamsCrop.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveBackgroundPostParamsCrop? ToEnum(string value)
        {
            return value switch
            {
                "false" => RemoveBackgroundPostParamsCrop.False,
                "true" => RemoveBackgroundPostParamsCrop.True,
                _ => null,
            };
        }
    }
}