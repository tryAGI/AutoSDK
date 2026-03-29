//HintName: G.Models.MuxDestinationOptionsPlaybackPolicyItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MuxDestinationOptionsPlaybackPolicyItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="signed")]
        Signed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MuxDestinationOptionsPlaybackPolicyItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MuxDestinationOptionsPlaybackPolicyItem value)
        {
            return value switch
            {
                MuxDestinationOptionsPlaybackPolicyItem.Public => "public",
                MuxDestinationOptionsPlaybackPolicyItem.Signed => "signed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MuxDestinationOptionsPlaybackPolicyItem? ToEnum(string value)
        {
            return value switch
            {
                "public" => MuxDestinationOptionsPlaybackPolicyItem.Public,
                "signed" => MuxDestinationOptionsPlaybackPolicyItem.Signed,
                _ => null,
            };
        }
    }
}