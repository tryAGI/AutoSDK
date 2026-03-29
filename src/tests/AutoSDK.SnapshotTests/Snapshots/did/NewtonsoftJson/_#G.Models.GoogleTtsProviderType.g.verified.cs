//HintName: G.Models.GoogleTtsProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleTtsProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleTtsProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleTtsProviderType value)
        {
            return value switch
            {
                GoogleTtsProviderType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleTtsProviderType? ToEnum(string value)
        {
            return value switch
            {
                "google" => GoogleTtsProviderType.Google,
                _ => null,
            };
        }
    }
}