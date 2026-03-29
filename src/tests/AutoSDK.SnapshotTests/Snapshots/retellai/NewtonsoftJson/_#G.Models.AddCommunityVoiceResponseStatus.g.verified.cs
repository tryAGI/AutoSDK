//HintName: G.Models.AddCommunityVoiceResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AddCommunityVoiceResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddCommunityVoiceResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddCommunityVoiceResponseStatus value)
        {
            return value switch
            {
                AddCommunityVoiceResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddCommunityVoiceResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AddCommunityVoiceResponseStatus.Error,
                _ => null,
            };
        }
    }
}