//HintName: G.Models.LlamaParseOutputOptionsImagesToSaveItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlamaParseOutputOptionsImagesToSaveItem
    {
        /// <summary>
        /// 
        /// </summary>
        Embedded,
        /// <summary>
        /// 
        /// </summary>
        Layout,
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlamaParseOutputOptionsImagesToSaveItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseOutputOptionsImagesToSaveItem value)
        {
            return value switch
            {
                LlamaParseOutputOptionsImagesToSaveItem.Embedded => "embedded",
                LlamaParseOutputOptionsImagesToSaveItem.Layout => "layout",
                LlamaParseOutputOptionsImagesToSaveItem.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseOutputOptionsImagesToSaveItem? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => LlamaParseOutputOptionsImagesToSaveItem.Embedded,
                "layout" => LlamaParseOutputOptionsImagesToSaveItem.Layout,
                "screenshot" => LlamaParseOutputOptionsImagesToSaveItem.Screenshot,
                _ => null,
            };
        }
    }
}