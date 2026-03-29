//HintName: G.Models.GetGlossaryEntriesAccept.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: text/tab-separated-values
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetGlossaryEntriesAccept
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text/tab-separated-values")]
        TextTabSeparatedValues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetGlossaryEntriesAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGlossaryEntriesAccept value)
        {
            return value switch
            {
                GetGlossaryEntriesAccept.TextTabSeparatedValues => "text/tab-separated-values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGlossaryEntriesAccept? ToEnum(string value)
        {
            return value switch
            {
                "text/tab-separated-values" => GetGlossaryEntriesAccept.TextTabSeparatedValues,
                _ => null,
            };
        }
    }
}