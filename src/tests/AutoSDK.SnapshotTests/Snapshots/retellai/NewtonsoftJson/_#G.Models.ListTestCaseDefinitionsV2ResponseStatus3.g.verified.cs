//HintName: G.Models.ListTestCaseDefinitionsV2ResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListTestCaseDefinitionsV2ResponseStatus3
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
    public static class ListTestCaseDefinitionsV2ResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTestCaseDefinitionsV2ResponseStatus3 value)
        {
            return value switch
            {
                ListTestCaseDefinitionsV2ResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTestCaseDefinitionsV2ResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListTestCaseDefinitionsV2ResponseStatus3.Error,
                _ => null,
            };
        }
    }
}