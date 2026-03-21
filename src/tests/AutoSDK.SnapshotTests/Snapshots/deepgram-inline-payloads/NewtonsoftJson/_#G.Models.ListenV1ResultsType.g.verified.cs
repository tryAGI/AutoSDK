//HintName: G.Models.ListenV1ResultsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListenV1ResultsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Results")]
        Results,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1ResultsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1ResultsType value)
        {
            return value switch
            {
                ListenV1ResultsType.Results => "Results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1ResultsType? ToEnum(string value)
        {
            return value switch
            {
                "Results" => ListenV1ResultsType.Results,
                _ => null,
            };
        }
    }
}