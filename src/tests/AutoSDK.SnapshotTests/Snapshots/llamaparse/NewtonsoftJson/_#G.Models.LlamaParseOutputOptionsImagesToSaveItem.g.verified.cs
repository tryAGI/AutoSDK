//HintName: G.Models.LlamaParseOutputOptionsImagesToSaveItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LlamaParseOutputOptionsImagesToSaveItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedded")]
        Embedded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="layout")]
        Layout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="screenshot")]
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