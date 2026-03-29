//HintName: G.Models.TransportConfigurationTwilioRecordingChannels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The number of channels in the final recording.<br/>
    /// Can be: `mono` or `dual`.<br/>
    /// The default is `mono`.<br/>
    /// `mono` records both legs of the call in a single channel of the recording file.<br/>
    /// `dual` records each leg to a separate channel of the recording file.<br/>
    /// The first channel of a dual-channel recording contains the parent call and the second channel contains the child call.<br/>
    /// @default 'mono'<br/>
    /// Example: mono
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransportConfigurationTwilioRecordingChannels
    {
        /// <summary>
        /// `mono` or `dual`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dual")]
        Dual,
        /// <summary>
        /// `mono` or `dual`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mono")]
        Mono,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransportConfigurationTwilioRecordingChannelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransportConfigurationTwilioRecordingChannels value)
        {
            return value switch
            {
                TransportConfigurationTwilioRecordingChannels.Dual => "dual",
                TransportConfigurationTwilioRecordingChannels.Mono => "mono",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransportConfigurationTwilioRecordingChannels? ToEnum(string value)
        {
            return value switch
            {
                "dual" => TransportConfigurationTwilioRecordingChannels.Dual,
                "mono" => TransportConfigurationTwilioRecordingChannels.Mono,
                _ => null,
            };
        }
    }
}