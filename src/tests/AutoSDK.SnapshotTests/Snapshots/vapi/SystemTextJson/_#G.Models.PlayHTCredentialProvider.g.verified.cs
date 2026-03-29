//HintName: G.Models.PlayHTCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlayHTCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Playht,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayHTCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayHTCredentialProvider value)
        {
            return value switch
            {
                PlayHTCredentialProvider.Playht => "playht",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayHTCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "playht" => PlayHTCredentialProvider.Playht,
                _ => null,
            };
        }
    }
}