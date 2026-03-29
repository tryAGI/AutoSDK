//HintName: G.Models.GetCaptionsAccept.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: application/x-subrip
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetCaptionsAccept
    {
        /// <summary>
        /// application/x-subrip for SRT or text/vtt for VTT
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="application/x-subrip")]
        ApplicationXSubrip,
        /// <summary>
        /// application/x-subrip for SRT or text/vtt for VTT
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text/vtt")]
        TextVtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCaptionsAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCaptionsAccept value)
        {
            return value switch
            {
                GetCaptionsAccept.ApplicationXSubrip => "application/x-subrip",
                GetCaptionsAccept.TextVtt => "text/vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCaptionsAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/x-subrip" => GetCaptionsAccept.ApplicationXSubrip,
                "text/vtt" => GetCaptionsAccept.TextVtt,
                _ => null,
            };
        }
    }
}