//HintName: G.Models.CreateImageRequestStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style of the generated images. This parameter is only supported for `dall-e-3`. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images.<br/>
    /// Default Value: vivid<br/>
    /// Example: vivid
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageRequestStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="natural")]
        Natural,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vivid")]
        Vivid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestStyle value)
        {
            return value switch
            {
                CreateImageRequestStyle.Natural => "natural",
                CreateImageRequestStyle.Vivid => "vivid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestStyle? ToEnum(string value)
        {
            return value switch
            {
                "natural" => CreateImageRequestStyle.Natural,
                "vivid" => CreateImageRequestStyle.Vivid,
                _ => null,
            };
        }
    }
}