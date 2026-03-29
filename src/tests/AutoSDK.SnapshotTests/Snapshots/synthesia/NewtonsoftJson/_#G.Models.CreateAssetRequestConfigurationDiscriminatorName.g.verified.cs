//HintName: G.Models.CreateAssetRequestConfigurationDiscriminatorName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAssetRequestConfigurationDiscriminatorName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbing")]
        Dubbing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssetRequestConfigurationDiscriminatorNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetRequestConfigurationDiscriminatorName value)
        {
            return value switch
            {
                CreateAssetRequestConfigurationDiscriminatorName.Dubbing => "dubbing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetRequestConfigurationDiscriminatorName? ToEnum(string value)
        {
            return value switch
            {
                "dubbing" => CreateAssetRequestConfigurationDiscriminatorName.Dubbing,
                _ => null,
            };
        }
    }
}