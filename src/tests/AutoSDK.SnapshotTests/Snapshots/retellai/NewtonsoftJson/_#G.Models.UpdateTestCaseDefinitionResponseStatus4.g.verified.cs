//HintName: G.Models.UpdateTestCaseDefinitionResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateTestCaseDefinitionResponseStatus4
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
    public static class UpdateTestCaseDefinitionResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTestCaseDefinitionResponseStatus4 value)
        {
            return value switch
            {
                UpdateTestCaseDefinitionResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTestCaseDefinitionResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateTestCaseDefinitionResponseStatus4.Error,
                _ => null,
            };
        }
    }
}