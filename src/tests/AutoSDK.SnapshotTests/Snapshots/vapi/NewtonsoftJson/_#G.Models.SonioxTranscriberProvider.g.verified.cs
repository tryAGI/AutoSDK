//HintName: G.Models.SonioxTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SonioxTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="soniox")]
        Soniox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SonioxTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SonioxTranscriberProvider value)
        {
            return value switch
            {
                SonioxTranscriberProvider.Soniox => "soniox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SonioxTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "soniox" => SonioxTranscriberProvider.Soniox,
                _ => null,
            };
        }
    }
}