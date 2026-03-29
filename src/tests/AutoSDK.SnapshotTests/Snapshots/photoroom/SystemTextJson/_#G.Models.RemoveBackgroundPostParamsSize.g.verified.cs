//HintName: G.Models.RemoveBackgroundPostParamsSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Will resize the output to the specified size. Can be `preview` (0.25 Megapixels), `medium` (1.5 MP), `hd` (4 MP) or `full` (36 MP, can be slower for large images). Useful for mobile apps that need smaller images.<br/>
    /// Default Value: full
    /// </summary>
    public enum RemoveBackgroundPostParamsSize
    {
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        Hd,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Preview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveBackgroundPostParamsSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveBackgroundPostParamsSize value)
        {
            return value switch
            {
                RemoveBackgroundPostParamsSize.Full => "full",
                RemoveBackgroundPostParamsSize.Hd => "hd",
                RemoveBackgroundPostParamsSize.Medium => "medium",
                RemoveBackgroundPostParamsSize.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveBackgroundPostParamsSize? ToEnum(string value)
        {
            return value switch
            {
                "full" => RemoveBackgroundPostParamsSize.Full,
                "hd" => RemoveBackgroundPostParamsSize.Hd,
                "medium" => RemoveBackgroundPostParamsSize.Medium,
                "preview" => RemoveBackgroundPostParamsSize.Preview,
                _ => null,
            };
        }
    }
}