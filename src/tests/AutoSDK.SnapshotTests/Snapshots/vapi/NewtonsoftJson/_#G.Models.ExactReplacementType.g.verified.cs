//HintName: G.Models.ExactReplacementType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the exact replacement type. You can use this to replace a specific word or phrase with a different word or phrase.<br/>
    /// Usage:<br/>
    /// - Replace "hello" with "hi": { type: 'exact', key: 'hello', value: 'hi' }<br/>
    /// - Replace "good morning" with "good day": { type: 'exact', key: 'good morning', value: 'good day' }<br/>
    /// - Replace a specific name: { type: 'exact', key: 'John Doe', value: 'Jane Smith' }<br/>
    /// - Replace an acronym: { type: 'exact', key: 'AI', value: 'Artificial Intelligence' }<br/>
    /// - Replace a company name with its phonetic pronunciation: { type: 'exact', key: 'Vapi', value: 'Vappy' }
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExactReplacementType
    {
        /// <summary>
        /// { type: 'exact', key: 'hello', value: 'hi' }
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exact")]
        Exact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExactReplacementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExactReplacementType value)
        {
            return value switch
            {
                ExactReplacementType.Exact => "exact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExactReplacementType? ToEnum(string value)
        {
            return value switch
            {
                "exact" => ExactReplacementType.Exact,
                _ => null,
            };
        }
    }
}