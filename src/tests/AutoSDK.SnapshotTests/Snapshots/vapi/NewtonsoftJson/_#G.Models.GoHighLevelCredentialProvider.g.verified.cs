//HintName: G.Models.GoHighLevelCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoHighLevelCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel")]
        Gohighlevel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoHighLevelCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelCredentialProvider value)
        {
            return value switch
            {
                GoHighLevelCredentialProvider.Gohighlevel => "gohighlevel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel" => GoHighLevelCredentialProvider.Gohighlevel,
                _ => null,
            };
        }
    }
}