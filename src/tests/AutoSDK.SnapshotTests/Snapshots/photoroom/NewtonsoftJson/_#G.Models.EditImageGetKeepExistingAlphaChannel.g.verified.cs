//HintName: G.Models.EditImageGetKeepExistingAlphaChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: never
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetKeepExistingAlphaChannel
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
    public static class EditImageGetKeepExistingAlphaChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetKeepExistingAlphaChannel value)
        {
            return value switch
            {
                EditImageGetKeepExistingAlphaChannel.Auto => "auto",
                EditImageGetKeepExistingAlphaChannel.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetKeepExistingAlphaChannel? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EditImageGetKeepExistingAlphaChannel.Auto,
                "never" => EditImageGetKeepExistingAlphaChannel.Never,
                _ => null,
            };
        }
    }
}