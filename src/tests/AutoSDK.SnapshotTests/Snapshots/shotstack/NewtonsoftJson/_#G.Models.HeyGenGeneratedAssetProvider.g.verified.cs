//HintName: G.Models.HeyGenGeneratedAssetProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the provider - set to `heygen` for HeyGen.<br/>
    /// Default Value: heygen
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HeyGenGeneratedAssetProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heygen")]
        Heygen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeyGenGeneratedAssetProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeyGenGeneratedAssetProvider value)
        {
            return value switch
            {
                HeyGenGeneratedAssetProvider.Heygen => "heygen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeyGenGeneratedAssetProvider? ToEnum(string value)
        {
            return value switch
            {
                "heygen" => HeyGenGeneratedAssetProvider.Heygen,
                _ => null,
            };
        }
    }
}