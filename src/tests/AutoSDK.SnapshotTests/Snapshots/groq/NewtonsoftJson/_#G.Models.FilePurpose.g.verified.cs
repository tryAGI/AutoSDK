//HintName: G.Models.FilePurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the file. Supported values are `batch`, and `batch_output`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batch")]
        Batch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batch_output")]
        BatchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilePurpose value)
        {
            return value switch
            {
                FilePurpose.Batch => "batch",
                FilePurpose.BatchOutput => "batch_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilePurpose? ToEnum(string value)
        {
            return value switch
            {
                "batch" => FilePurpose.Batch,
                "batch_output" => FilePurpose.BatchOutput,
                _ => null,
            };
        }
    }
}