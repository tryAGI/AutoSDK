//HintName: G.Models.ListTestRunsV2ResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListTestRunsV2ResponseStatus5
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
    public static class ListTestRunsV2ResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTestRunsV2ResponseStatus5 value)
        {
            return value switch
            {
                ListTestRunsV2ResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTestRunsV2ResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListTestRunsV2ResponseStatus5.Error,
                _ => null,
            };
        }
    }
}