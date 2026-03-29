//HintName: G.Models.MultiVectorComparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MultiVectorComparator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_sim")]
        MaxSim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultiVectorComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiVectorComparator value)
        {
            return value switch
            {
                MultiVectorComparator.MaxSim => "max_sim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiVectorComparator? ToEnum(string value)
        {
            return value switch
            {
                "max_sim" => MultiVectorComparator.MaxSim,
                _ => null,
            };
        }
    }
}