//HintName: G.Models.LlamaParseParametersImagesToSaveVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LlamaParseParametersImagesToSaveVariant1Item
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
    public static class LlamaParseParametersImagesToSaveVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseParametersImagesToSaveVariant1Item value)
        {
            return value switch
            {
                LlamaParseParametersImagesToSaveVariant1Item.Embedded => "embedded",
                LlamaParseParametersImagesToSaveVariant1Item.Layout => "layout",
                LlamaParseParametersImagesToSaveVariant1Item.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseParametersImagesToSaveVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => LlamaParseParametersImagesToSaveVariant1Item.Embedded,
                "layout" => LlamaParseParametersImagesToSaveVariant1Item.Layout,
                "screenshot" => LlamaParseParametersImagesToSaveVariant1Item.Screenshot,
                _ => null,
            };
        }
    }
}