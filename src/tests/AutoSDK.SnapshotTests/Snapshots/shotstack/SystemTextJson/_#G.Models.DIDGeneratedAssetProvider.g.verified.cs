//HintName: G.Models.DIDGeneratedAssetProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the provider - set to `d-id` for D-ID.<br/>
    /// Default Value: d-id
    /// </summary>
    public enum DIDGeneratedAssetProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DIDGeneratedAssetProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DIDGeneratedAssetProvider value)
        {
            return value switch
            {
                DIDGeneratedAssetProvider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DIDGeneratedAssetProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => DIDGeneratedAssetProvider.DId,
                _ => null,
            };
        }
    }
}