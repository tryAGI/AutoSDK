//HintName: G.Models.CreateImageRequestStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style of the generated images. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images. This param is only supported for `dall-e-3`.
    /// <br/>Default Value: vivid
    /// <br/>Example: vivid
    /// </summary>
    public enum CreateImageRequestStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Vivid,
        /// <summary>
        /// 
        /// </summary>
        Natural,
    }

    public static class CreateImageRequestStyleExtensions
    {
        public static string ToValueString(this CreateImageRequestStyle value)
        {
            return value switch
            {
                CreateImageRequestStyle.Vivid => "vivid",
                CreateImageRequestStyle.Natural => "natural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestStyle ToEnum(string value)
        {
            return value switch
            {
                "vivid" => CreateImageRequestStyle.Vivid,
                "natural" => CreateImageRequestStyle.Natural,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestStyle ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageRequestStyle.Vivid,
                1 => CreateImageRequestStyle.Natural,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}