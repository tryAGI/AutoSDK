//HintName: G.Models.EditImageGetLayersVariant2ImageUseForAIBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetLayersVariant2ImageUseForAIBackground
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="never")]
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetLayersVariant2ImageUseForAIBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetLayersVariant2ImageUseForAIBackground value)
        {
            return value switch
            {
                EditImageGetLayersVariant2ImageUseForAIBackground.Auto => "auto",
                EditImageGetLayersVariant2ImageUseForAIBackground.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetLayersVariant2ImageUseForAIBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EditImageGetLayersVariant2ImageUseForAIBackground.Auto,
                "never" => EditImageGetLayersVariant2ImageUseForAIBackground.Never,
                _ => null,
            };
        }
    }
}