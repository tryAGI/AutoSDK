//HintName: G.Models.FileSchemaPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file. Only accepts fine-tuning (`fine-tune`) for now.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FileSchemaPurpose
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
    public static class FileSchemaPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSchemaPurpose value)
        {
            return value switch
            {
                FileSchemaPurpose.FineTune => "fine-tune",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSchemaPurpose? ToEnum(string value)
        {
            return value switch
            {
                "fine-tune" => FileSchemaPurpose.FineTune,
                _ => null,
            };
        }
    }
}