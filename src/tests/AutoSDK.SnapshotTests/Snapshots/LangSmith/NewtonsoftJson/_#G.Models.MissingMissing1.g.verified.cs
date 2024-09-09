//HintName: G.Models.MissingMissing1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MissingMissing1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="__missing__")]
        Missing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MissingMissing1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MissingMissing1 value)
        {
            return value switch
            {
                MissingMissing1.Missing => "__missing__",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MissingMissing1? ToEnum(string value)
        {
            return value switch
            {
                "__missing__" => MissingMissing1.Missing,
                _ => null,
            };
        }
    }
}