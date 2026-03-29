//HintName: G.Models.ShotstackGeneratedAssetProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the provider - set to `shotstack` for Shotstack.<br/>
    /// Default Value: shotstack
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShotstackGeneratedAssetProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shotstack")]
        Shotstack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShotstackGeneratedAssetProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShotstackGeneratedAssetProvider value)
        {
            return value switch
            {
                ShotstackGeneratedAssetProvider.Shotstack => "shotstack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShotstackGeneratedAssetProvider? ToEnum(string value)
        {
            return value switch
            {
                "shotstack" => ShotstackGeneratedAssetProvider.Shotstack,
                _ => null,
            };
        }
    }
}