//HintName: G.Models.DIDGeneratedAssetOptionsDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DIDGeneratedAssetOptionsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-avatar")]
        TextToAvatar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DIDGeneratedAssetOptionsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DIDGeneratedAssetOptionsDiscriminatorType value)
        {
            return value switch
            {
                DIDGeneratedAssetOptionsDiscriminatorType.TextToAvatar => "text-to-avatar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DIDGeneratedAssetOptionsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-avatar" => DIDGeneratedAssetOptionsDiscriminatorType.TextToAvatar,
                _ => null,
            };
        }
    }
}