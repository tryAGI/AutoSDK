//HintName: G.Models.MaskingAccept.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: application/json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MaskingAccept
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="application/json")]
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/png")]
        ImagePng,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MaskingAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MaskingAccept value)
        {
            return value switch
            {
                MaskingAccept.ApplicationJson => "application/json",
                MaskingAccept.ImagePng => "image/png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MaskingAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => MaskingAccept.ApplicationJson,
                "image/png" => MaskingAccept.ImagePng,
                _ => null,
            };
        }
    }
}