//HintName: G.Models.PreRecordedResponseKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: pre-recorded<br/>
    /// Example: pre-recorded
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PreRecordedResponseKind
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pre-recorded")]
        PreRecorded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreRecordedResponseKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreRecordedResponseKind value)
        {
            return value switch
            {
                PreRecordedResponseKind.PreRecorded => "pre-recorded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreRecordedResponseKind? ToEnum(string value)
        {
            return value switch
            {
                "pre-recorded" => PreRecordedResponseKind.PreRecorded,
                _ => null,
            };
        }
    }
}