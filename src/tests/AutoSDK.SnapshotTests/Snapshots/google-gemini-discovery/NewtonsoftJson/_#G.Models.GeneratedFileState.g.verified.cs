//HintName: G.Models.GeneratedFileState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output only. The state of the GeneratedFile.<br/>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GeneratedFileState
    {
        /// <summary>
        /// Failed to generate the GeneratedFile.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// Generated and is ready for download.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GENERATED")]
        Generated,
        /// <summary>
        /// Being generated.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GENERATING")]
        Generating,
        /// <summary>
        /// The default value. This value is used if the state is omitted.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_UNSPECIFIED")]
        StateUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedFileStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedFileState value)
        {
            return value switch
            {
                GeneratedFileState.Failed => "FAILED",
                GeneratedFileState.Generated => "GENERATED",
                GeneratedFileState.Generating => "GENERATING",
                GeneratedFileState.StateUnspecified => "STATE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedFileState? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => GeneratedFileState.Failed,
                "GENERATED" => GeneratedFileState.Generated,
                "GENERATING" => GeneratedFileState.Generating,
                "STATE_UNSPECIFIED" => GeneratedFileState.StateUnspecified,
                _ => null,
            };
        }
    }
}