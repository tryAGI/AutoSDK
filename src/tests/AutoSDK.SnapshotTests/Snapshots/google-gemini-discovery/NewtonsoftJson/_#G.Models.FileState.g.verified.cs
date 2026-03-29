//HintName: G.Models.FileState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output only. Processing state of the File.<br/>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FileState
    {
        /// <summary>
        /// File is processed and available for inference.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ACTIVE")]
        Active,
        /// <summary>
        /// File failed processing.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// File is being processed and cannot be used for inference yet.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROCESSING")]
        Processing,
        /// <summary>
        /// The default value. This value is used if the state is omitted.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_UNSPECIFIED")]
        StateUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileState value)
        {
            return value switch
            {
                FileState.Active => "ACTIVE",
                FileState.Failed => "FAILED",
                FileState.Processing => "PROCESSING",
                FileState.StateUnspecified => "STATE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileState? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => FileState.Active,
                "FAILED" => FileState.Failed,
                "PROCESSING" => FileState.Processing,
                "STATE_UNSPECIFIED" => FileState.StateUnspecified,
                _ => null,
            };
        }
    }
}