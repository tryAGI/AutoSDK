//HintName: G.Models.FileResponsePurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: fine-tune
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FileResponsePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fine-tune")]
        FineTune,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileResponsePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileResponsePurpose value)
        {
            return value switch
            {
                FileResponsePurpose.FineTune => "fine-tune",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileResponsePurpose? ToEnum(string value)
        {
            return value switch
            {
                "fine-tune" => FileResponsePurpose.FineTune,
                _ => null,
            };
        }
    }
}