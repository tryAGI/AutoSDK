//HintName: G.Models.ListTranscriptionResponseItemsDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListTranscriptionResponseItemsDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live")]
        Live,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pre-recorded")]
        PreRecorded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTranscriptionResponseItemsDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTranscriptionResponseItemsDiscriminatorKind value)
        {
            return value switch
            {
                ListTranscriptionResponseItemsDiscriminatorKind.Live => "live",
                ListTranscriptionResponseItemsDiscriminatorKind.PreRecorded => "pre-recorded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTranscriptionResponseItemsDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "live" => ListTranscriptionResponseItemsDiscriminatorKind.Live,
                "pre-recorded" => ListTranscriptionResponseItemsDiscriminatorKind.PreRecorded,
                _ => null,
            };
        }
    }
}