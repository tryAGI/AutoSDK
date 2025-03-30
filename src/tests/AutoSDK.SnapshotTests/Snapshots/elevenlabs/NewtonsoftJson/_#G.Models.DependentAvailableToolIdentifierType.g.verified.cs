//HintName: G.Models.DependentAvailableToolIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: available
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependentAvailableToolIdentifierType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="available")]
        Available,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependentAvailableToolIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentAvailableToolIdentifierType value)
        {
            return value switch
            {
                DependentAvailableToolIdentifierType.Available => "available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentAvailableToolIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "available" => DependentAvailableToolIdentifierType.Available,
                _ => null,
            };
        }
    }
}