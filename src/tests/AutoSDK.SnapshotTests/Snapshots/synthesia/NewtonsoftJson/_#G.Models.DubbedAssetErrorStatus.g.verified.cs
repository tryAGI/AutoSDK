//HintName: G.Models.DubbedAssetErrorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the dubbed video.<br/>
    /// Default Value: error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DubbedAssetErrorStatus
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
    public static class DubbedAssetErrorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbedAssetErrorStatus value)
        {
            return value switch
            {
                DubbedAssetErrorStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbedAssetErrorStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DubbedAssetErrorStatus.Error,
                _ => null,
            };
        }
    }
}