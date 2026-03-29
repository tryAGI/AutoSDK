//HintName: G.Models.PassageSearchRequestTagMatchMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to match tags - 'any' to match passages with any of the tags, 'all' to match only passages with all tags<br/>
    /// Default Value: any
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PassageSearchRequestTagMatchMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="any")]
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassageSearchRequestTagMatchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassageSearchRequestTagMatchMode value)
        {
            return value switch
            {
                PassageSearchRequestTagMatchMode.All => "all",
                PassageSearchRequestTagMatchMode.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassageSearchRequestTagMatchMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => PassageSearchRequestTagMatchMode.All,
                "any" => PassageSearchRequestTagMatchMode.Any,
                _ => null,
            };
        }
    }
}